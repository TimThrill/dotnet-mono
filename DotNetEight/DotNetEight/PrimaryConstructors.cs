namespace DotNetEight
{
    /// <summary>
    /// The name constructor parameter is used for the value assigned to the Name property
    /// </summary>
    /// <param name="name">The desired name of the class</param>
    public class PrimaryConstructorForPropertyInitilization(string name)
    {
        public string Name { get; } = name;

        public override string ToString() => Name;
    }

    /// <summary>
    /// The name constructor parameter is passed to the parent class constructor
    /// </summary>
    /// <param name="name">The desired name of the class</param>
    public class PrimaryConstructorForBaseConstructor(string name) : PrimaryConstructorForPropertyInitilization(name)
    {
    }

    /// <summary>
    /// The constructor parameter rawName is referenced by the AppendToInstanceName method.
    /// A local variable will be created by the compiler in this instance.
    /// </summary>
    /// <param name="rawName"></param>
    public class PrimaryConstructorForInstanceMember(string rawName)
    {
        public string Name => rawName;

        public void AppendToInstanceName(string appendContent) 
        {
            rawName += appendContent; 
        }
    }
}
