### Learned

- `using static System.Console;` permits short-hand notation like WriteLine() without also always writing the preceding `Console.` notation. Yuck is gone. Great praise be!
- 

### Actionables

###### tested concepts needing review
- proper exception throwing conventions (1v)
- requirements to succesfully overriding methods (1)
- generics (22, 25)
- delegates (32)

### Interesting Questions

Up to 3 answers may be correct per question.

1. Which of the following are required to override the `Equals()` method in C#?
   1. `obj.Equals(obj)` must return "false".
   2. `obj.Equals(null)` must return "true".
   3. The derived class must not override the `GetHasCode` of the base class.
   4. `obj1.Equals(obj2)` and `obj2.Equals(ob1)` must return the same value.
   5. The equals method of the derived class must throw away any exceptions raised.

    - *selected: iv*
    - *uncertain: iii*



25. Which of the following are valid statements regarding the use of generics in C#?
    1. Generic classes are not type-safe.
    2. Generics improve code reuse.
    3. Generic classes may not be constrained.
    4. Generic types maximize performance.
    5. Generics do not allow type information to be known at compile-time.
    
    - *selected: ii, v*


32. Which of the following are valid statements regarding C# delegates?
    1. Delegates do not allow methods to be passed on parameters.
    2. Delegates cannot be used with generic parameters.
    3. Delegates are used to pass methods as arguments to other methods.
    4. Delegates are not type safe.
    5. Delegates are ideal for callback functions.