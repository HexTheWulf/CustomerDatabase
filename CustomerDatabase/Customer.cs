using System;

public class Customer
{
    string Name;
    char DirectionalLocation;

    public string Name1 {
        get {
            return Name;
        }

        set {
            Name = value;
        }
    }

    public char DirectionalLocation1 {
        get {
            return DirectionalLocation;
        }

        set {
            DirectionalLocation = value;
        }
    }

    public Customer()
	{
        Name1 = "John Doe";
        DirectionalLocation1 = 'N';
	}

    public Customer(string name, char dir) {
        Name = name;
        DirectionalLocation = dir;
    }
}
