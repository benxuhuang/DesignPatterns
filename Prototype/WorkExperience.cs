using System;

public class WorkExperience : ICloneable {
    public string WorkDate { get; set; }    
    public string Company { get; set; }
    public object Clone(){
        return this.MemberwiseClone();
    }
}