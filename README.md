# Encapsulation Example OOP: (Object Oriented Programming).
*Overview Module Objectives: Objects & Classes*

    Objectives for this module:

      * Create a program that utilizes objects and classes
      * Create and use a class that demonstrates correct use of encapsulation
      * Create and use a class that demonstrates aggregation or composition
    
    In Practice: Dice Rolling class
   
        - How can we represent an individual die?
            * Data
            * Functionality
        - What should be public and what should be private?
            * Interacting with the class
        - How should the object be created?
            * How can a valid state be maintained?
        
    Results: Readable, Maintainable, OOP concepts, Public and Private where necessary...
    
Concept Of Constructor Chaining In C#: https://www.c-sharpcorner.com/Blogs/concept-of-constructor-chaining-in-c-sharp
  
Random Class Resource: https://docs.microsoft.com/en-us/dotnet/api/system.random?view=net-5.0

    Avoiding multiple instantiations:
    
    On the .NET Framework, initializing two random number generators in a tight loop or in rapid succession
    creates two random number generators that can produce identical sequences of random numbers.
    
    In most cases, this is not the developer's intent and can lead to performance issues,
    because instantiating and initializing a random number generator is a relatively expensive process.

    Both to improve performance and to avoid inadvertently creating separate random number generators
    that generate identical numeric sequences,
    
    *** we recommend that you create one Random object to generate many random numbers over time,
    instead of creating new Random objects to generate one random number. 

## SOLID is an acronym for 5 important design principles
*Explanation Resource:* https://itnext.io/solid-principles-explanation-and-examples-715b975dcad4

    SOLID Programming:

      (S) Single responsibility principle:
            - A class should have one purpose.
      (O) Open/closed principle:
            - Open for extension but closed for modification.
      (L) Liskov substitution principle:
            - Inheritance and Polymorphism: sub/derived types can be used for their base/super class.
      (I) Interface segregation principle:
            - Interfaces
      (D) Dependency Inversion principle:
          - One class does not depend on a specific concrete class. Utilize interfaces.

