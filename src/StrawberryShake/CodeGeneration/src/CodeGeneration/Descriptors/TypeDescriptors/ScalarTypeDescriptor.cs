using HotChocolate;

namespace StrawberryShake.CodeGeneration.Descriptors.TypeDescriptors;

public sealed class ScalarTypeDescriptor : ILeafTypeDescriptor
{
    public ScalarTypeDescriptor(
        string name,
        RuntimeTypeInfo runtimeType,
        RuntimeTypeInfo serializationType)
    {
        Name = name;
        RuntimeType = runtimeType;
        SerializationType = serializationType;
    }

    /// <summary>
    /// Gets the GraphQL type name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the type kind.
    /// </summary>
    public TypeKind Kind => TypeKind.Leaf;

    /// <summary>
    /// Gets the .NET runtime type of the GraphQL type.
    /// </summary>
    public RuntimeTypeInfo RuntimeType { get; }

    /// <summary>
    /// Gets the .NET serialization type.
    /// (the way we transport a leaf value.)
    /// </summary>
    public RuntimeTypeInfo SerializationType { get; }
}
