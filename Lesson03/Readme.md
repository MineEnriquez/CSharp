# About Abstract Classes

* Why and when should we use an abstract class
* Give an example of where we could use an abstract class


--
PROBLEM:
Having two very similar classes, class 1 and class 2, notice that there is only very few differences.
Definitelly related.
There is a lot of common properties and methods.
There is a lot of duplicate code.
If we want to add 'Middle name' we have to do it in both classes, so,mainteinability is not good.

CLASS 1:
Full Time employee

CLASS 2:
Contract Employee

DECISION POINT:
In order to fix the code duplicity:
  - should we redesign the project with an Abstract Class?
  - should we redesignt it as a Concrete Class ( non abstract). 

  If we create "BaseEmployee" class as a concrete class (Non-Abstract), there is nothing stopping us from creating an instance of BaseEmployee class. 
  We only have 2 types of employees in our organization - contract employee and full time employee. The developer should only need to instantiate ContractEmployee and FullTimeEmployee classes and *not BaseEmployee class* So to avoid *this* we implement instead an Abstract Class. 

  ### We would create an abstract class when we want to move the common functionality of 2 or more classes into a base class and when we don't want the BASE CLASS TO BE *DIRECTLY* INSTANTIATED.


- 1: Move the common properties to the Base class
- 2: Move the common methods to the Base class
- 3: Inherit the ContractEmployee and FullTimeEmployee from the BaseEmployee class.