using System;

public sealed class Singleton5
{
	Singleton5
	{
	}

    public static Singleton5 Instance
{
    get
    {
        return Nested.Instance;
    }
}

    class Nested
{
    static Nested()
    {
    }

    private static readonly Singleton5 instance = new Singleton5();

    internal static Singleton5 Instance => instance;
}
}
