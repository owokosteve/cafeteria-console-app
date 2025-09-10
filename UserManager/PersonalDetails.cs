namespace cafeconnect;

public enum Gender
{
    Male,
    Female,
    Transgender
}
public class PersonalDetials
{
    public string? Name { get; set; }
    public string? FatherName { get; set; }
    public Gender Gender { get; set; }
    public string? Mobile { get; set; }
    public string? Mail { get; set; }
}