# Bitcode

## Decorator pattern
Dynamically adds responsibility to the interface by wrapping the original code

References https://assist-software.net/blog/implementation-decorator-pattern-c

The decorator pattern can be used **to extend (decorate) the functionality of a certain object statically**, or in some cases at run-time, independently of other instances of the same class, provided some groundwork is done at design time. This is achieved by **designing a new decorator class that wraps the original class.**

This pattern is designed so that multiple decorators can be stacked on top of each other, each time adding a new functionality to the overridden method(s).

## Visitor pattern
The Visitor pattern is possibly the most complicated design pattern you will face.
https://manski.net/2013/05/the-visitor-pattern-explained/
