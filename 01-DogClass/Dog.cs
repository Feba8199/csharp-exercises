
namespace Coding.Exercise
{
    public class Dog
    {
        private string name;
        private string breed;
        private int weight;
        
        public Dog(string name, string breed, int weight) 
        {
            this.name = name;
            this.breed  = breed;
            this.weight = weight;
        }
        
        public Dog(string name, int weight) : this(name,"mixed-breed", weight)
        {
            this.name = name;
            this.weight = weight;
        }
        
        private string GetSizeDescription()
        {
            return weight switch
            {
                <5 => "tiny",
                <30 => "medium",
                _ => "large"
            };
        }
        
        public string Describe() 
        {
            return $"This dog is named {name}, it's a {breed}, and it weighs {weight} kilograms, so it's a {GetSizeDescription()} dog.";
        }
        
    }
}
