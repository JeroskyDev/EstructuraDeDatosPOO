namespace ConceptsOfOPP.Backend;

public class Invoice : IPay //this means, implement the interface
{
    //fields
    private float _quantity;
    private decimal _value;

    //constructors
    public Invoice(int id, string description, Date date, float quantity, decimal value)
    {
        Id = id;
        Description = description;
        Date = date;
        Quantity = quantity;
        Value = value;
    }

    //properties
    public int Id { get; set; }
    public string Description { get; set; } = null!;

    public Date Date { get; set; }
    public float Quantity 
    {
        get => _quantity;
        set => _quantity = ValidateQuantity(value);
    }
    public decimal Value 
    { 
        get => _value; 
        set => _value = ValidateValue(value); 
    }


    //methods

    //override
    public override string ToString()
    {
        return $"{Id}\t{Description}\n\t" +
               $"Value: {Value,20:C2}\n\t" +
               $"Quantity: {Quantity,20:N2}\n\t" +
               $"Value to pay: {GetValueToPay(),20:C2}";
    }

    //public methods
    public decimal GetValueToPay() => Value * (decimal)Quantity;
    

    //private methods
    private float ValidateQuantity(float quantity)
    {
        if(quantity < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity has to be HIGHER or EQUAL to 0.");
        }
        return quantity;
    }

    private decimal ValidateValue(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "value has to be HIGHER or EQUAL to 0.");
        }
        return value;
    }

}
