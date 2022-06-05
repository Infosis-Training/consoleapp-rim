class Properties
{
    string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length >= 2)
            {
                name = value;
            }
        }
    }
    
     public double Average {get; set;}
     public string  Addres {get; set;}
    
}