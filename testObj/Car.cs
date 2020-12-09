class Car{
    private int id;
    private string color;

    public Car(int id, string color){
        this.id = id;
        this.color = color;
    }

    public int Id{
        get { return id; }
        set { id = value; }
    }

    public string Color{
        get { return color; }
        set { color = value; }
    }

    public double Price{ get; set; }
}