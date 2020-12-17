using System;

public class Resume : ICloneable {
    private string _name;
    private string _gender;
    private string _age;
    private WorkExperience _work;

    public Resume(string name)
    {
        this._name = name;
        _work = new WorkExperience();
    }

    private Resume(WorkExperience work) {
        _work = (WorkExperience)work.Clone();
    }

    public void SetPersonalInfo(string gender, string age){
        _gender = gender;
        _age = age;
    }
    public void SetWorkExperience(string workDate, string company){
        _work.WorkDate = workDate;
        _work.Company = company;
    }

    public void Display(){
        Console.WriteLine("{0} {1} {2}",_name,_gender,_age);      
        Console.WriteLine("工作經歷 {0} {1}",_work.WorkDate,_work.Company);      
    }
      
      public object Clone(){
          Resume obj = new Resume(this._work);
          obj._name = this._name;
          obj._gender = this._gender;
          obj._age = this._age;
          return obj;
      }
} 