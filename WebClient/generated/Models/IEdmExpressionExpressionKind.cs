// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IEdmExpressionExpressionKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IEdmExpressionExpressionKind
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "BinaryConstant")]
        BinaryConstant,
        [EnumMember(Value = "BooleanConstant")]
        BooleanConstant,
        [EnumMember(Value = "DateTimeOffsetConstant")]
        DateTimeOffsetConstant,
        [EnumMember(Value = "DecimalConstant")]
        DecimalConstant,
        [EnumMember(Value = "FloatingConstant")]
        FloatingConstant,
        [EnumMember(Value = "GuidConstant")]
        GuidConstant,
        [EnumMember(Value = "IntegerConstant")]
        IntegerConstant,
        [EnumMember(Value = "StringConstant")]
        StringConstant,
        [EnumMember(Value = "DurationConstant")]
        DurationConstant,
        [EnumMember(Value = "Null")]
        Null,
        [EnumMember(Value = "Record")]
        Record,
        [EnumMember(Value = "Collection")]
        Collection,
        [EnumMember(Value = "Path")]
        Path,
        [EnumMember(Value = "If")]
        If,
        [EnumMember(Value = "Cast")]
        Cast,
        [EnumMember(Value = "IsType")]
        IsType,
        [EnumMember(Value = "FunctionApplication")]
        FunctionApplication,
        [EnumMember(Value = "LabeledExpressionReference")]
        LabeledExpressionReference,
        [EnumMember(Value = "Labeled")]
        Labeled,
        [EnumMember(Value = "PropertyPath")]
        PropertyPath,
        [EnumMember(Value = "NavigationPropertyPath")]
        NavigationPropertyPath,
        [EnumMember(Value = "DateConstant")]
        DateConstant,
        [EnumMember(Value = "TimeOfDayConstant")]
        TimeOfDayConstant,
        [EnumMember(Value = "EnumMember")]
        EnumMember,
        [EnumMember(Value = "AnnotationPath")]
        AnnotationPath
    }
    internal static class IEdmExpressionExpressionKindEnumExtension
    {
        internal static string ToSerializedValue(this IEdmExpressionExpressionKind? value)
        {
            return value == null ? null : ((IEdmExpressionExpressionKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IEdmExpressionExpressionKind value)
        {
            switch( value )
            {
                case IEdmExpressionExpressionKind.None:
                    return "None";
                case IEdmExpressionExpressionKind.BinaryConstant:
                    return "BinaryConstant";
                case IEdmExpressionExpressionKind.BooleanConstant:
                    return "BooleanConstant";
                case IEdmExpressionExpressionKind.DateTimeOffsetConstant:
                    return "DateTimeOffsetConstant";
                case IEdmExpressionExpressionKind.DecimalConstant:
                    return "DecimalConstant";
                case IEdmExpressionExpressionKind.FloatingConstant:
                    return "FloatingConstant";
                case IEdmExpressionExpressionKind.GuidConstant:
                    return "GuidConstant";
                case IEdmExpressionExpressionKind.IntegerConstant:
                    return "IntegerConstant";
                case IEdmExpressionExpressionKind.StringConstant:
                    return "StringConstant";
                case IEdmExpressionExpressionKind.DurationConstant:
                    return "DurationConstant";
                case IEdmExpressionExpressionKind.Null:
                    return "Null";
                case IEdmExpressionExpressionKind.Record:
                    return "Record";
                case IEdmExpressionExpressionKind.Collection:
                    return "Collection";
                case IEdmExpressionExpressionKind.Path:
                    return "Path";
                case IEdmExpressionExpressionKind.If:
                    return "If";
                case IEdmExpressionExpressionKind.Cast:
                    return "Cast";
                case IEdmExpressionExpressionKind.IsType:
                    return "IsType";
                case IEdmExpressionExpressionKind.FunctionApplication:
                    return "FunctionApplication";
                case IEdmExpressionExpressionKind.LabeledExpressionReference:
                    return "LabeledExpressionReference";
                case IEdmExpressionExpressionKind.Labeled:
                    return "Labeled";
                case IEdmExpressionExpressionKind.PropertyPath:
                    return "PropertyPath";
                case IEdmExpressionExpressionKind.NavigationPropertyPath:
                    return "NavigationPropertyPath";
                case IEdmExpressionExpressionKind.DateConstant:
                    return "DateConstant";
                case IEdmExpressionExpressionKind.TimeOfDayConstant:
                    return "TimeOfDayConstant";
                case IEdmExpressionExpressionKind.EnumMember:
                    return "EnumMember";
                case IEdmExpressionExpressionKind.AnnotationPath:
                    return "AnnotationPath";
            }
            return null;
        }

        internal static IEdmExpressionExpressionKind? ParseIEdmExpressionExpressionKind(this string value)
        {
            switch( value )
            {
                case "None":
                    return IEdmExpressionExpressionKind.None;
                case "BinaryConstant":
                    return IEdmExpressionExpressionKind.BinaryConstant;
                case "BooleanConstant":
                    return IEdmExpressionExpressionKind.BooleanConstant;
                case "DateTimeOffsetConstant":
                    return IEdmExpressionExpressionKind.DateTimeOffsetConstant;
                case "DecimalConstant":
                    return IEdmExpressionExpressionKind.DecimalConstant;
                case "FloatingConstant":
                    return IEdmExpressionExpressionKind.FloatingConstant;
                case "GuidConstant":
                    return IEdmExpressionExpressionKind.GuidConstant;
                case "IntegerConstant":
                    return IEdmExpressionExpressionKind.IntegerConstant;
                case "StringConstant":
                    return IEdmExpressionExpressionKind.StringConstant;
                case "DurationConstant":
                    return IEdmExpressionExpressionKind.DurationConstant;
                case "Null":
                    return IEdmExpressionExpressionKind.Null;
                case "Record":
                    return IEdmExpressionExpressionKind.Record;
                case "Collection":
                    return IEdmExpressionExpressionKind.Collection;
                case "Path":
                    return IEdmExpressionExpressionKind.Path;
                case "If":
                    return IEdmExpressionExpressionKind.If;
                case "Cast":
                    return IEdmExpressionExpressionKind.Cast;
                case "IsType":
                    return IEdmExpressionExpressionKind.IsType;
                case "FunctionApplication":
                    return IEdmExpressionExpressionKind.FunctionApplication;
                case "LabeledExpressionReference":
                    return IEdmExpressionExpressionKind.LabeledExpressionReference;
                case "Labeled":
                    return IEdmExpressionExpressionKind.Labeled;
                case "PropertyPath":
                    return IEdmExpressionExpressionKind.PropertyPath;
                case "NavigationPropertyPath":
                    return IEdmExpressionExpressionKind.NavigationPropertyPath;
                case "DateConstant":
                    return IEdmExpressionExpressionKind.DateConstant;
                case "TimeOfDayConstant":
                    return IEdmExpressionExpressionKind.TimeOfDayConstant;
                case "EnumMember":
                    return IEdmExpressionExpressionKind.EnumMember;
                case "AnnotationPath":
                    return IEdmExpressionExpressionKind.AnnotationPath;
            }
            return null;
        }
    }
}
