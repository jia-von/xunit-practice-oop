# C# XUnit Practice within Object-Orientated Programming

This goal of this assignment is designed to help myself to familiarize with the fundamentals of XUnit testing in an object-oriented implementation.
 

## Installation

Packages used within this assignment includes:
- Microsoft.NET.Test.Sdk
- xunit

## Approach

 - A solution and console application was created with a name ***XUnitOOPPractice***.
 - A second XUnit Test project was created with solution name ***XUnitOOPPractice_Tests***.
 - Assembly reference from the XUnit project to the console application.

 - A program with three classes were created:
   - public abstract class, ***MenuItem***.
   - inherited class from ***MenuItem***, ***FoodItem*** and ***Combo***.
   - public class, ***Order***.

- Unit tests were created to test the following behaviour:
  - Adding a single item of each type to the order using ***Facts***.
  - Add a Combo to the order using ***Fact***.
  - Remove a single item from the order using ***Fact***.
  - Remove a combo from the order using ***Fact***.
  - The Combo’s Price reflects the sum of the items minus 20% using ***Theory***.


### Screenshot
![Example Screenshot of XUnit testing](/ReferenceMaterials/UnitTest_ScreenShot.PNG)