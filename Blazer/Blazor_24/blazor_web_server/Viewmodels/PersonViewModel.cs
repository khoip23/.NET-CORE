using System;

namespace blazor_web_server.ViewModels;

class PersonViewModel
{
    public int Id { get; set; } = 2;
    public string Name { get; set; } = "ABC";
    public int Age { get; set; } = 18;
    public string Image{ get; set; } = "";
    public PersonViewModel()
    {
        Image = $"https://i.pravatar.cc?u={Id}";
    }

    public PersonViewModel(int newId, string newName, int newAge)
    {
        Id = newId;
        Name = newName;
        Age = newAge;
        Image = $"https://i.pravatar.cc?u={Id}";
    }
} 2:05