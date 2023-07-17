namespace MadLib.Models;

public class MadLibVariables {
    public string Noun { get; set;} 
    // public string Verb { get; set;} 
    // public string Place { get; set;}

    public MadLibVariables(string noun) {
        Noun = noun;
    }

}
