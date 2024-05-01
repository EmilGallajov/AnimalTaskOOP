## This is an assignment for improving "Objected Oriented Programming" skils.

This project is a C# console application that focuses on OOP. 

## Getting Started

To get started with this project, follow these steps:

1. Clone the repository to your local machine.
2. Open the project in your preferred C# IDE (e.g., Visual Studio).
3. Build and run the project.

## Main Objective
This application demonstrates object-oriented programming concepts such as inheritance, abstraction, and interfaces.

## Task Structure (Requirements)

    1.Animal Class
        Data:
            Age: Random integer between 1-100
            SkinColor: Random enum (White, Black, Grey)
            Calories: Random integer between 500-1000
        Behavior:
            Sleep(int hours): Adds hours*20 to calories.
            Eat(int calories): Adds calories to the calories.

    2.Dog Class (Extends Animal)
        Data:
            Speed: Random integer between 10-20
        Behavior:
            Talk(): Prints "Woof."
            Walk(int hours): Subtracts hours*speed/2 from the calories.

    3.Reptile Class (Extends Animal)
        Data:
            AnimalType: Random enum (Crocodile, Lizard)
        Behavior:
            Talk(): Prints "Ssrr."
            Walk(int hours):
                Crocodile: Subtracts hours*15 from the calories.
                Lizard: Subtracts hours*10 from the calories.
            Swim(int hours):
                Crocodile: Subtracts hours*10 from the calories.
                Lizard: Subtracts hours*5 from the calories.

    4.Fish Class (Extends Animal)
        Data:
            Size: Random integer between 1-10
        Behavior:
            Talk(): Prints "..."
            Swim(int hours): Subtracts hours*size from the calories.

Additional Structures

    ISwim Interface
        Contains Swim method.

    IWalk Interface
        Contains Walk method.

    Animal Abstract Class
        Abstract method Talk.
