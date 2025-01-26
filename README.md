# Day1_CSharpProblems

This repository contains a C# console application that includes various problems and solutions, including distance calculations between 3D points and fraction addition. It demonstrates the use of basic C# features, user input handling, and simple mathematical operations.

## Features

- **Calculate Distance Between Two 3D Points**: Users can input coordinates for two 3D points and calculate the distance between them.
- **Perform Fraction Addition**: Users can input numerators and denominators for two fractions and compute their sum.

## Getting Started

### Prerequisites

- .NET SDK (version 5.0 or later) installed on your machine.

### Running the Application

1. **Clone the Repository**
    ```bash
    git clone https://github.com/Ahmvdaziz/Day1_CSharpProblems.git
    ```

2. **Navigate to the Project Directory**
    ```bash
    cd Day1_CSharpProblems
    ```

3. **Build the Project**
    ```bash
    dotnet build
    ```

4. **Run the Application**
    ```bash
    dotnet run
    ```

### Usage

Upon running the application, you will see a menu with the following options:

1. **Calculate Distance Between Two Points**: 
   - Enter the x, y, and z coordinates for two 3D points.
   - The application will display the coordinates and calculate the distance between them.

2. **Perform Fraction Addition**: 
   - Enter numerators and denominators for two fractions.
   - The application will display the fractions and compute their sum.
3. **Exit**: 
   - Choose this option to exit the application.

### Code Structure

- **`Program.cs`**: Contains the `Main` method, which handles user input and executes functionality based on user choice.
- **`_3DPoint.cs`**: Defines the `_3DPoint` class with properties for coordinates, a method to get input from the user, a method to display the point, and a method to calculate distance.
- **`Fraction.cs`**: Defines the `Fraction` class with properties for numerator and denominator, a method to display the fraction, and a method to add two fractions.



