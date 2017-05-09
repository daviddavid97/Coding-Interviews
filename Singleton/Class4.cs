﻿using System;

public sealed class Singleton4
{
	private Singleton4()
	{
	}

    private static Singleton4 instance = new Singleton4();
    public static Singleton4 Instance
    {
        get
        {
            return instance;
        }
    }
}
