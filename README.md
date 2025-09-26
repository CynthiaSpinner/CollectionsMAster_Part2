# Collections Master App - Advanced Collections

## Overview
This exercise helps you master **advanced C# collections** through hands-on practice with HashSet, Stack, Queue, and SortedList. These are specialized collections that go beyond basic arrays, lists, and dictionaries.

## Structure

### Main Focus: Advanced Collections
Practice specialized collection operations with powerful C# collections:

- **HashSet<T>** (3 operations): Create, Add unique items, Check duplicates & count
- **Stack<T>** (3 operations): Create, Push items, Pop items (LIFO)
- **Queue<T>** (3 operations): Create, Enqueue items, Dequeue items (FIFO)
- **SortedList<TKey,TValue>** (3 operations): Create, Add key-value pairs, Display sorted data

## How to Complete This Exercise

### Step 1: Implement Method Logic
First, scroll to the bottom of the file and implement the method:

```csharp
private static HashSet<string> CreateHashSet()
{
    // TODO: Create a HashSet of strings (automatically prevents duplicates)
    // Example: HashSet<string> uniqueNames = new HashSet<string>();
    // Then return uniqueNames;
    
    return null; // Replace this line with your implementation
}
```

### Step 2: Call the Method in Main
Back in the Main method, you'll see TODOs like:

```csharp
Console.WriteLine("\n1. HASHSET CREATE:");
// TODO 17: Call CreateHashSet() method and store result in a variable
var uniqueNames = CreateHashSet();
```

### Step 3: Test Your Work
- Run the program after implementing each method
- Watch how each collection behaves differently
- Each operation has clear console labels to show progress

## Learning Approach

### HashSet (Unique Items Only)
- **Purpose**: Automatically prevents duplicate items
- **Key Concept**: Fast lookups and guaranteed uniqueness
- **Real-world Use**: User permissions, unique tags, visited pages

### Stack (Last-In-First-Out)
- **Purpose**: LIFO operations like a stack of plates
- **Key Concept**: Push to add, Pop to remove from top
- **Real-world Use**: Undo operations, function call stack, browser history

### Queue (First-In-First-Out)
- **Purpose**: FIFO operations like a line at a store
- **Key Concept**: Enqueue to add, Dequeue to remove from front
- **Real-world Use**: Print queues, task processing, breadth-first search

### SortedList (Auto-Sorted Key-Value Pairs)
- **Purpose**: Key-value pairs automatically sorted by key
- **Key Concept**: Fast lookups with automatic ordering
- **Real-world Use**: Leaderboards, indexed data, sorted catalogs

## Key Learning Outcomes

### Technical Skills:
- Master specialized collection operations beyond arrays, lists, and dictionaries
- Understand when to use advanced collections vs basic collections
- Learn LIFO vs FIFO data structures
- Practice key-value pair management with automatic sorting
- Understand set operations and duplicate prevention

### Professional Skills:
- Research advanced collection documentation
- Choose the right collection type for specific problems
- Write efficient, specialized data handling code
- Test and debug collection-specific behaviors

## Tips for Success

1. **Complete in Order**: HashSet → Stack → Queue → SortedList
2. **Test Frequently**: Run the program after each method implementation
3. **Watch the Behavior**: Notice how each collection handles data differently
4. **Use the Reference**: Scroll to bottom of Program.cs for complete method lists
5. **Understand the Why**: Learn when each collection type is most useful
6. **Experiment**: Try adding the same item twice to HashSet, or reversing Stack/Queue operations

## Collection Comparison Quick Reference

| Collection | Purpose | Add Method | Remove Method | Key Feature |
|------------|---------|------------|---------------|-------------|
| HashSet<T> | Unique items | Add() | Remove() | No duplicates |
| Stack<T> | LIFO operations | Push() | Pop() | Last in, first out |
| Queue<T> | FIFO operations | Enqueue() | Dequeue() | First in, first out |
| SortedList<K,V> | Sorted key-value | Add(key,value) | Remove(key) | Auto-sorted by key |

## Getting Help

### Built-in References:
- 📚 **Complete method lists** at the bottom of Program.cs
- **Step-by-step instructions** in each method stub
- **Clear examples** and usage hints in TODO comments

### External Resources:
- **Microsoft Docs**: [docs.microsoft.com/dotnet/api/system.collections.generic](https://docs.microsoft.com/dotnet/api/system.collections.generic)
- **C# Documentation**: [learn.microsoft.com/dotnet/csharp/](https://learn.microsoft.com/dotnet/csharp/)
- **IntelliSense**: Type collection name + Ctrl+Space for methods
- **Stack Overflow**: Search for specific collection questions

## Why These Collections Matter

These advanced collections solve specific problems that arrays, lists, and dictionaries can't handle efficiently:

- **HashSet**: When you need guaranteed uniqueness without manual checking
- **Stack**: When you need to reverse order or implement undo functionality
- **Queue**: When you need fair ordering (first-come, first-served)
- **SortedList**: When you need both key-value lookup AND sorted order

Master these, and you'll have powerful tools for solving complex data problems!

Happy coding! 🚀
