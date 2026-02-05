# 📘 OOP Learning Plan – C# (.NET)

This repository documents my step-by-step learning of Object-Oriented Programming (OOP) in C#, including theory, practice, and GitHub exercises.

---


# csharp
# DAY1

- new repository for cshar in studgrill
- create new 7 empty folders from day1 to day 7
- getting c# running and absolute basics

## theory
- what is chsarp and .NET (high level)
- console apps what and why
- what is program.cs and entrypoint of console apps
- variables and types
- how to input and output in c#
- loops all types

## PRACTICAL
- read two numbers from a user and print those numbers and their sum
- print numbers 1-20 using any loop
- write a method IsEven(int n) which will check if a given number is even or not and return the same

## github exercise
- console basics and calculator
- create a calculator menu which will have 4 options addition,sub,mul and divi

- # Day 2

## OOP Concepts: Classes and Objects

---

## Learning Objectives
- Learn all types of errors in C#
- Understand the basics of Object-Oriented Programming (OOP)

---

## Theory
- What is a class and what is an object  
- How do we create an object in C#  
- Why OOP? (bundling data + behaviour together)  
- How to use an object to instantiate methods and fields  

---

## Practice
- Create a class `Person` with:
  - `name`
  - `age`
- Add a method called `Introduce` in the class  

---

## Exercise (GitHub)
- Create a class called `Person` which will have:
  - Two fields: `name` and `age`
  - A method `Introduce`
- Create three people and print their introductions  
- Add one more class called `Address` with fields:
  1. `street`
  2. `city`
- Attach `Address` to `Person` as a field (should be a simple **has-a relationship**)  
- Do this in **Day 1**
- You have to add an option saying:
  - After you have done your process, you will give an option to the user if he wants to quit or not  
  - If he says **yes**, then you exit  
  - Otherwise, you repeat the operation  
  - The same applies unless he says **no**

  # DAY-3

## FIX
- FIX THE solution of the git exercise -2 using class as a field inside a class

## Encapsulation (properly) ***
- properties,constructors,validation

## Theory
- what is encapsulation
- access modifiers(public,private,protected,internal)
- fileds vs properties (getter setter)
- constructors (how objects start life)
- validation inside constructors and methods
- learn static (static methods and parameters)

## Practice
- copy paste exercise 2 after fix
- age field should reject negatives
- make introduce function in such a way that i should not have to crete a object to call it (static)

## Exercise
- bank account encapsulation(name)
- create a class called bank account which willhave 4 fields owner name ,balance ,deposits,withdraw
- owner name should set one in constructor
- balance should be readable but not directly changeable
- deposit or withdraw (both should have validation)
- create a console menu to test all the operatons


# Day 4 - Collections + Working with many objects

## Goal
- Handle Multiple objects using collections and simple searching.

## Learn (Theory)
1. List<T> - What, Why and How
2. Add, Remove and Loop on List
3. Finding items by Id or specific key ( Simple loop only, No Linq)
4. Separating Logic, How to separate logic using Model in classes, not only using just Program.cs. (Learn bare basic, do not dive into different types of models)

## Practice
1. Create List<Person> and search by name
2. Print all items neatly from the list using Loop

## Github Exercise (MiniLibrary Collection)
1. Create class Book (Id, Title, IsBorrowed)
2. Create list Library which holds List<Book>
3. Add features - Add book to the Library, List all availble books, Boorow and Return books by Id



## 📅 Day 5 – Inheritance & Polymorphism

### 🎯 Goals
- Understand IS-A relationships
- Learn and apply Inheritance and Polymorphism

---

### 📖 Theory

#### Inheritance in C#
- What is inheritance in C#
- How inheritance works
- Why inheritance is used
- Multiple inheritance (theory only – not supported in C#)

#### Polymorphism
- What is polymorphism
- Why polymorphism is useful
- Types of polymorphism:
  - Method Overloading
  - Method Overriding

#### Keywords
- virtual
- override

#### Design Consideration
- When not to use inheritance

---

### 🧪 Practice

#### Animal Inheritance Example
- Create a base class `Animal`
- Create derived classes:
  - `Dog`
  - `Cat`
- Create a method `Speak()` in `Animal`
- Override `Speak()` in each derived class
- Loop through a list of animals and call `Speak()`

---

### 🧠 Git Exercise – Shapes Inheritance

- Create an abstract class `Shape`
  - Method: `GetArea()`
- Create derived classes:
  - `Circle`
  - `Rectangle`
  - `Triangle`
- Override `GetArea()` in each class
- Print areas for a list of shapes

---

## 📅 Day 6 – Interfaces

### 📖 Theory

#### Types of Inheritance
- Class inheritance
- Interface inheritance

#### Interfaces
- What is an interface
- Why interfaces are used
- How interfaces work
- CAN-DO relationship (not IS-A)

#### Additional Topics
- Examples of different types of inheritance
- Examples of interfaces
- Composition using interfaces

---

### 🧪 Practice

#### Logger Interface
- Create an interface `ILogger`
- Create `ConsoleLogger`
- Use `ILogger` inside another class

---

### 🧠 Git Exercise – Notifier Interfaces

- Create an interface `INotifier`
  - Method: `Send(string message)`
- Create two classes:
  - `ConsoleNotifier`
  - `EmailNotifier`
- Create `OrderService` class
  - Uses `INotifier` to send updates
  - Use constructor injection
- In `Program.cs`:
  - Switch notifier type
  - Observe different behavior

---

## 📅 Day 7 – Abstraction & Capstone (OOP Integration)

### 📖 Theory

1. What abstraction means (practical understanding)
   - User cares about what a class does
   - User does not care how it does it
2. When to use abstraction
3. Abstraction vs Encapsulation
4. Recap of all OOP concepts learned

---

### 🧠 Practice (No Coding)

#### Identify Abstractions

Answer:
1. Should `Program.cs` care where tasks are stored?
2. Should it care what operations are possible?

Write down:
- One interface name for task storage
- One interface name for task operations

#### Method Signatures Only (No Implementations)
- Task Creation
- Task Completion
- Get All Tasks

Use interface-first thinking.

---

## 🧠 GitHub Capstone – Task Tracker

### 📦 Model

Create a class `TaskItem` with:
- `int Id`
- `string Title`
- `bool IsCompleted`

#### Method
- `MarkCompleted()`

---

### 🧩 Repository Abstraction

Create an interface `ITaskRepository` with methods:

```csharp
void Add(TaskItem task);
List<TaskItem> GetAll();
TaskItem GetById(int id);

