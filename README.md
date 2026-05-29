# Singleton

Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

## Benefits of Factory Method Pattern

1. Encapsulates object creation
2. Promotes code reusability
3. Supports open/closed principle

## How to use it

1. Create a sealed class
2. Use a private constructor
3. Create a private static instance of the class
4. Create a public static property that returns the instanced class or if null then creates one

## When to use it

Use factory method when the service is:

- There several implementations of an interface
- There is creation complexity
- You want to decouple the code
- You need to decide the type in runtime

Avoid factory method when:

- There is a simple class only
- There is no logic in the creation of the class
