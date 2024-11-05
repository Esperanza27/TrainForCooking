using System.Text.Json.Serialization;

namespace TrainForCooking.Dto;
public enum Unit
{
    Gr,    // grammi
    Kg,    // chilogrammi
    Ml,    // millilitri
    Cup,   // tazze
    Tbsp,  // cucchiai
    Tsp,   // cucchiaini
    unit   // unità
}
public class Ingredient
{
    [JsonIgnore]// quando non voglio fa vedere una propietà
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int Quantity { get; set; }
    public Unit unitOfMeasure { get; set; }
}
