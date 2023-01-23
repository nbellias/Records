# Records

## Records in C# are intended to be used for simple data structures that are mainly used for data storage and manipulation. Some examples of when to use records include:

### Representing simple data types: Records are a great way to represent simple data types such as points, rectangles, or sizes, that have no behavior and are only used to store data.

### Immutable data: Records are value types, and by default, they are immutable, which means that once an instance of a record is created, its properties cannot be changed. This can be useful for situations where you need to ensure that data cannot be modified accidentally.

### Data transfer objects: Records are lightweight, and they can be used to represent data that is passed between layers of an application, such as between a web service and a client application.

### As function return types: Records can be useful as return types in functions, you can use them to represent the output of a function.

### Records are not intended to be used for more complex types that have behavior or need to maintain state. For those types, you should use classes.

### Additionally, records can be a good choice when you need to use value-based semantics, which is guaranteed that two records with the same properties will be the same. This can be useful in situations where you need to use the data structure as a key in a dictionary or in other scenarios where the object identity is not important.

### In summary, records are a good choice for simple data structures, such as data transfer objects, that don't need to maintain state or have behavior, and when you need to use value-based semantics.
