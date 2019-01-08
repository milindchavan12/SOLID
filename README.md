# SOLID

## 1. Single Responsibility Principle (S.R.P)
> A class should have one, and only one, reason to change.
![img text](https://www.tomdalling.com/images/posts/srp.jpg)

## 3. The Liskov Substitution Principle
Functions that use pointers to base classes must be able to use objects of derived classes without knowing it.

> Derived classes must be substitutable for their base classes.
This principle was named for Barbara Liskov, who first described the principle in 1988.

Now to have substitutability work, child classes must not :
1. Remove Base class behaviour
2. Violate Base class invariants

The Liskov Principle is implemented in "Solid.Liskov" Project

![alt text](https://www.tomdalling.com/images/posts/lsp.jpg)

## 4. Interface Segregation Principle (ISP)
The Interface Segregation Principle states that client should not be forced to depend on methods they do not use. Interface Segregation violations result in the classes that depends upon they don't need, increasing coupling, reducing flexibility and maintainability.  

## 5. Dependency Inversion Principle
High-Level modules should not depend upon low-level modules. Both should depend upon abstractions. Abstractions should not depend upon details. Details should depend upon abstractions.

Dependancy Injection is technique that is used to allow calling code to inject the dependancies a class needs when it is instantiated.

Three Primary Principles:
- Constructor Injection
- Property Injection
- Parameter Injection 

### IoC Container
- Responsible for object graph instantiation
- Initiated at Application Start via code or configurations
- Managed interfaces and implemention to be used are registered with container
