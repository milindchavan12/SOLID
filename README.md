# SOLID

# 3. The Liskov Substitution Principle
The Liskov Substitution Principle states that subtypes must be substitutable for their base types. 
This principle was named for Barbara Liskov, who first described the principle in 1988.

Now to have substitutability work, child classes must not :
1. Remove Base class behaviour
2. Violate Base class invariants

The Liskov Principle is implemented in "Solid.Liskov" Project

# 4. Interface Segregation Principle (ISP)
The Interface Segregation Principle states that client should not be forced to depend on methods they do not use. Interface Segregation violations result in the classes that depends upon they don't need, increasing coupling, reducing flexibility and maintainability.  

# 5. Dependency Inversion Principle
High-Level modules should not depend upon low-level modules. Both should depend upon abstractions. Abstractions should not depend upon details. Details should depend upon abstractions.
