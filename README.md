# C# OOP (Object-Oriented Programming) Tutorial Notes

This document summarizes the key topics in C# OOP that you should study and practice.  
It follows the sequence of tutorials for better understanding.

---

## 📑 Table of Contents
1. [Introduction, Classes and Objects](#1-introduction-classes-and-objects)
2. [Constructors in Programming](#2-constructors-in-programming)
3. [Events and Event Handlers](#3-events-and-event-handlers)
4. [Encapsulation Explained](#4-encapsulation-explained)
5. [Inheritance Explained](#5-inheritance-explained)
6. [Polymorphism](#6-polymorphism)
7. [Partial Classes](#7-partial-classes)
8. [Interfaces](#8-interfaces)
9. [Override Keyword & Overriding Methods](#9-override-keyword--overriding-methods)
10. [Static Properties and Static Methods](#10-static-properties-and-static-methods)
11. [How to Study](#-how-to-study)
12. [Recommended Practice](#-recommended-practice)

---

## 1. Introduction, Classes and Objects
- What is Object-Oriented Programming (OOP)?
- Difference between **Class** (blueprint) and **Object** (instance).
- How to define a class in C#.
- Creating and using objects.

---

## 2. Constructors in Programming
- Purpose of constructors.
- Types of constructors:
  - Default constructor
  - Parameterized constructor
  - Copy constructor
- Constructor overloading.

---

## 3. Events and Event Handlers
- What are events in C#.
- Delegates and how they connect to events.
- Defining and subscribing to events.
- Event-driven programming examples.

---

## 4. Encapsulation Explained
- Concept of **data hiding**.
- Using **private fields** with **public properties**.
- `get` and `set` accessors.
- Benefits of encapsulation in real-world applications.

---

## 5. Inheritance Explained
- What is inheritance and why it is used.
- Base (parent) and derived (child) classes.
- `: base` keyword in C#.
- Benefits of code reuse.

---

## 6. Polymorphism
- Concept of “many forms.”
- Compile-time polymorphism (method overloading).
- Run-time polymorphism (method overriding with `virtual` and `override`).
- Example: Shapes (Circle, Rectangle) implementing different behaviors.

---

## 7. Partial Classes
- Splitting one class across multiple files.
- Benefits: teamwork and maintainability.
- Example usage in auto-generated code.

---

## 8. Interfaces
- What are interfaces and why we use them.
- Defining and implementing interfaces.
- Difference between **abstract classes** and **interfaces**.
- Real-world examples (e.g., `IDisposable`, `IEnumerable`).

---

## 9. Override Keyword & Overriding Methods
- Difference between **method overloading** and **overriding**.
- Using `virtual`, `override`, and `sealed`.
- Rules of method overriding in C#.

---

## 10. Static Properties and Static Methods
- What does `static` mean in C#.
- Static fields and methods shared across all objects.
- When to use static vs instance members.
- Example: Utility classes like `Math`.

---

## ✅ How to Study
1. Start with **Classes and Objects** as the foundation.  
2. Move to **Constructors** → **Encapsulation** → **Inheritance**.  
3. Learn **Polymorphism** for flexible code.  
4. Explore **Events** and **Interfaces** for real-world applications.  
5. Finish with advanced concepts like **Partial Classes** and **Static Members**.  

---

## 🚀 Recommended Practice
- Build a simple **Bank Account System**:
  - Encapsulation: Balance field with getter/setter.
  - Constructors: Initialize account details.
  - Inheritance: SavingsAccount, CheckingAccount.
  - Polymorphism: Different `Withdraw` implementations.
  - Interface: `ITransaction` for Deposit/Withdraw.
  - Events: Trigger event when balance is low.

---
