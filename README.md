# C# XUnit Practice within Object-Orientated Programming

This goal of this assignment is designed to help myself to familiarize with the fundamentals of XUnit testing in an object-oriented implementation.
 

## Installation

Packages used within this assignment includes:
- Microsoft.NET.Test.Sdk
- xunit

```bash
$ git clone https://github.com/jia-von/xunit-practice-oop.git
$ cd xunit-practice-oop-jia-von
$ cd XUnitOOPPractice
$ start devenv XUnitOOPPractice.sln
````

## Approach

 - A solution and console application was created with a name `XUnitOOPPractice.sln`.
 - A second XUnit Test project was created with solution name `XUnitOOPPractice_Tests.sln`.
 - Assembly reference from the XUnit project to the console application.

 - A program with three classes were created:
   - public abstract class, `MenuItem.cs`.
   - inherited class from `MenuItem.cs`, `FoodItem.cs`, and `Combo.cs`.
   - public class, `Order.cs`.

- Unit tests were created to test the following behaviour:
  - Adding a single item of each type to the order using `[Facts]`.
  - Add a Combo to the order using `[Fact]`.
  - Remove a single item from the order using `[Fact]`.
  - Remove a combo from the order using `[Fact]`.
  - The Combo’s Price reflects the sum of the items minus 20% using `[Theory]`.


### Screenshot
![Example Screenshot of XUnit testing](/ReferenceMaterials/UnitTest_ScreenShot.PNG)