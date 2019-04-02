# CustomList

Custom list is a custom data structure built from the ground up using Test Driven Development in C#. It is designed to mirror the original list functionality built into C# and contains six methods (Add, Remove, ToString, Zip, and + and – overloads).

<hr/>

## Development Process

Custom List was built using test driven development (TDD), where each method was given at least five unit test before the method was written. When the test where completed the member methods of the CustomList class were written in a way to pass those test.

The Add and Remove methods were created first with the other four being created after. The other methods take advantage of the Add and Remove within them for functionality. The highest time complexity of the member methods created was BigO(n log n).