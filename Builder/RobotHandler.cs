using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClient;
using WebClient.Models;

namespace Builder
{
    class RobotHandler
    {
        public static async Task<List<RobotDto>> CreateRobotsAsync(UiPathWebApi api, string robotName,
            string username, int numRobots, int pagination)
        {
            var createdRobots = new List<RobotDto>();
            for (int i = 0; i < numRobots; i += pagination)
            {
                var robotTaskArray = new List<Task<RobotDto>>();
                for (int j = i; j < i + pagination && j < numRobots; j++)
                {
                    robotTaskArray.Add(api.Robots.PostAsync(new RobotDto(robotName + j.ToString(),
                        username + j.ToString(), RobotDtoType.Attended, RobotDtoHostingType.Floating)));
                }
                var robots = await Task.WhenAll(robotTaskArray);
                var robotsList = robots.OfType<RobotDto>().ToList();
                createdRobots.AddRange(robotsList);
            }
            return createdRobots;
        }

        public static async Task<List<RobotDto>> GetRobotsAsync(UiPathWebApi api, int numRobots, int pagination)
        {
            List<RobotDto> robots = new List<RobotDto>();
            for (int i = 0; i < numRobots; i += pagination)
            {
                var nextRobots = await api.Robots.GetRobotsAsync(skip: i, top: pagination);
                var robotsList = nextRobots.Value;
                robots.AddRange(robotsList);
            }
            return robots;
        }


        public static async Task AddRobotsEnviromentAsync(UiPathWebApi api, EnvironmentDto environmentDto,
            List<RobotDto> robots, int pagination)
        {
            int numRobots = robots.Count;
            for (int i = 0; i < numRobots; i += pagination)
            {
                List<Task> tasks = new List<Task>();
                for (int j = i; j < i + pagination && j < numRobots; j++)
                {
                    tasks.Add(api.Environments.AddRobotByIdAsync(environmentDto.Id.Value,
                                new AddRobotParameters(robots[j].Id.Value.ToString())));
                }
                await Task.WhenAll(tasks);
            }
        }

        public static async Task GetEnvironmentsAsync(UiPathWebApi api, string pathToFile)
        {
            var environments = await api.Environments.GetEnvironmentsAsync(expand: "Robots");
            var environmentsList = environments.Value;
            foreach (var environment in environmentsList)
            {
                string fileName = $"{pathToFile}{environment.Name}.json";
                string jsonEnvironment = JsonConvert.SerializeObject(environment);
                File.WriteAllText(fileName, jsonEnvironment);
            }
        }
    }
}
