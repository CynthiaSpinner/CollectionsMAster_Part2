using System;
using System.Collections.Generic;

/// <summary>
/// Collections Master App - Learn C# Advanced Collections
/// Complete TODOs to master 4 different advanced collection types
/// 
/// FOCUS: ADVANCED COLLECTIONS
/// 1. HashSet<T> - Stores unique items only, automatically prevents duplicates
/// 2. Stack<T> - Last-In-First-Out (LIFO) like a stack of plates
/// 3. Queue<T> - First-In-First-Out (FIFO) like a line at a store
/// 4. SortedList<TKey,TValue> - Key-value pairs kept automatically sorted by key
/// 
/// ================================================================================
/// 📚 COLLECTIONS METHODS REFERENCE - SCROLL TO BOTTOM FOR ALL COLLECTION METHODS! 📚
/// ================================================================================
/// 
/// WHERE TO RESEARCH:
/// - Microsoft Docs: docs.microsoft.com/dotnet/api/system.collections.generic
/// - C# Documentation: learn.microsoft.com/dotnet/csharp/
/// - IntelliSense: Type the collection name and press Ctrl+Space for methods
/// - Stack Overflow: stackoverflow.com (search for specific collection questions)
/// - GitHub Examples: github.com (search for C# collection examples)
/// </summary>

namespace CollectionsMasterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ⚠️  IMPORTANT: DO NOT START HERE! ⚠️
            // 🔽 SCROLL DOWN TO THE METHODS SECTION FIRST! 🔽
            // 📍 Look for "START HERE" comment below to implement methods FIRST
            // Then come back here to call your implemented methods
            #region HashSet
            Console.WriteLine("*** HASHSET ***");
            Console.WriteLine("=".PadRight(60, '='));
            Console.WriteLine("Stores unique items only, automatically prevents duplicates");

            Console.WriteLine("\n1. HASHSET CREATE:");
            // TODO 17: Call CreateHashSet() method and store result in a variable
            // Implement the CreateHashSet() method at bottom of file
            
            Console.WriteLine("\n2. HASHSET ADD:");
            // TODO 18: Call AddToHashSet(uniqueNames) method
            // Implement the AddToHashSet() method at bottom of file
            
            Console.WriteLine("\n3. HASHSET COUNT & CONTAINS:");
            // TODO 19: Call CheckHashSetCount(uniqueNames) method
            // Implement the CheckHashSetCount() method at bottom of file

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF HASHSET SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            #region Stack
            Console.WriteLine("*** STACK ***");
            Console.WriteLine("=".PadRight(60, '='));
            Console.WriteLine("Last-In-First-Out (LIFO) like a stack of plates");

            Console.WriteLine("\n1. STACK CREATE:");
            // TODO 20: Call CreateStack() method and store result in a variable
            // Implement the CreateStack() method at bottom of file
            
            Console.WriteLine("\n2. STACK PUSH:");
            // TODO 21: Call PushToStack(stack) method
            // Implement the PushToStack() method at bottom of file
            
            Console.WriteLine("\n3. STACK POP:");
            // TODO 22: Call PopFromStack(stack) method
            // Implement the PopFromStack() method at bottom of file

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF STACK SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            #region Queue
            Console.WriteLine("*** QUEUE ***");
            Console.WriteLine("=".PadRight(60, '='));
            Console.WriteLine("First-In-First-Out (FIFO) like a line at a store");

            Console.WriteLine("\n1. QUEUE CREATE:");
            // TODO 23: Call CreateQueue() method and store result in a variable
            // Implement the CreateQueue() method at bottom of file
            
            Console.WriteLine("\n2. QUEUE ENQUEUE:");
            // TODO 24: Call EnqueueToQueue(queue) method
            // Implement the EnqueueToQueue() method at bottom of file
            
            Console.WriteLine("\n3. QUEUE DEQUEUE:");
            // TODO 25: Call DequeueFromQueue(queue) method
            // Implement the DequeueFromQueue() method at bottom of file

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF QUEUE SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion


            #region SortedList
            Console.WriteLine("*** SORTEDLIST ***");
            Console.WriteLine("=".PadRight(60, '='));
            Console.WriteLine("Key-value pairs kept automatically sorted by key");

            Console.WriteLine("\n1. SORTEDLIST CREATE:");
            // TODO 26: Call CreateSortedList() method and store result in a variable
            // Implement the CreateSortedList() method at bottom of file
            
            Console.WriteLine("\n2. SORTEDLIST ADD:");
            // TODO 27: Call AddToSortedList(sorted) method
            // Implement the AddToSortedList() method at bottom of file
            
            Console.WriteLine("\n3. SORTEDLIST DISPLAY:");
            // TODO 28: Call DisplaySortedList(sorted) method
            // Implement the DisplaySortedList() method at bottom of file

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF SORTEDLIST SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            Console.WriteLine("🎉 COLLECTIONS MASTER COMPLETE! 🎉");
            Console.ReadKey();
           
        }

        // ================================================================================
        // 🚀 START HERE! IMPLEMENT THESE METHODS FIRST! 🚀
        // ================================================================================
        // 📋 INSTRUCTIONS:
        // 1. Implement each method below (replace "return null;" with your code)
        // 2. After implementing a method, go back to Main() to call it
        // 3. Test each method by running the program
        // 4. Move to the next method only after the current one works
        // ================================================================================

        // ============ HASHSET METHODS ============

        private static HashSet<string> CreateHashSet()
        {
            // TODO: Create a HashSet of strings (automatically prevents duplicates)
            // Example: HashSet<string> uniqueNames = new HashSet<string>();
            // Then return uniqueNames;
            
            return null;
        }

        private static void AddToHashSet(HashSet<string> uniqueNames)
        {
            // TODO: Add "John", "Jane", and "John" again (watch the duplicate get ignored!)
            // Example: uniqueNames.Add("John");
            
            // TODO: Print all unique names using a foreach loop
            // Example: foreach (string name in uniqueNames)
            
            Console.WriteLine("Unique names in HashSet:");
        }

        private static void CheckHashSetCount(HashSet<string> uniqueNames)
        {
            // TODO: Print the count of unique names
            // Example: Console.WriteLine($"Total unique names: {uniqueNames.Count}");
            
            // TODO: Check if specific names exist using Contains
            // Example: Console.WriteLine($"Contains John: {uniqueNames.Contains(\"John\")}");
            
        }

        // ============ STACK METHODS ============

        private static Stack<int> CreateStack()
        {
            // TODO: Create a Stack of integers (Last In, First Out - like a stack of plates)
            // Example: Stack<int> stack = new Stack<int>();
            // Then return stack;
            
            return null;
        }

        private static void PushToStack(Stack<int> stack)
        {
            // TODO: Push the numbers 10, 20, 30 onto the stack
            // Example: stack.Push(10);
            
            Console.WriteLine("Pushed 10, 20, 30 onto stack");
            Console.WriteLine($"Stack count: {stack.Count}");
        }

        private static void PopFromStack(Stack<int> stack)
        {
            Console.WriteLine("Popping from stack (LIFO order):");
            
            // TODO: Pop all items while the stack has items (they come out in reverse order!)
            // Example: while (stack.Count > 0)
            // Example: int item = stack.Pop();
            
        }

        // ============ QUEUE METHODS ============

        private static Queue<string> CreateQueue()
        {
            // TODO: Create a Queue of strings (First In, First Out - like a line at a store)
            // Example: Queue<string> queue = new Queue<string>();
            // Then return queue;
            
            return null;
        }

        private static void EnqueueToQueue(Queue<string> queue)
        {
            // TODO: Add "First", "Second", "Third" to the queue
            // Example: queue.Enqueue("First");
            
            Console.WriteLine("Enqueued: First, Second, Third");
            Console.WriteLine($"Queue count: {queue.Count}");
        }

        private static void DequeueFromQueue(Queue<string> queue)
        {
            Console.WriteLine("Dequeuing from queue (FIFO order):");
            
            // TODO: Remove all items while the queue has items (they come out in same order!)
            // Example: while (queue.Count > 0)
            // Example: string item = queue.Dequeue();
            
        }
 // ============ SORTEDLIST METHODS ============

        private static SortedList<int, string> CreateSortedList()
        {
            // TODO: Create a SortedList with int keys and string values (automatically sorted by key)
            //
            // Example: SortedList<int, string> sorted = new SortedList<int, string>();
            // Then return sorted;
            SortedList<int, string> sorted = new SortedList<int, string>();
            Console.WriteLine("Sorted List created!");

            return sorted;
        }

        private static void AddToSortedList(SortedList<int, string> sorted)
        {
            // TODO: Add key-value pairs out of order - watch them get sorted automatically!
            // Example: sorted.Add(3, "Third");
            
            Console.WriteLine("Added items out of order: 3=Third, 1=First, 2=Second");
        }

        private static void DisplaySortedList(SortedList<int, string> sorted)
        {
            Console.WriteLine("SortedList contents (automatically sorted by key):");
            
            // TODO: Loop through and print each key-value pair
            // Example: foreach (var item in sorted)
            
        }
    }

    /*
    ================================================================================
    DETAILED METHOD REFERENCES FOR STUDENT RESEARCH
    ================================================================================
    
    CORE HASHSET METHODS TO RESEARCH:
    - Add(item) - Add unique item (returns false if duplicate)
    - Contains(item) - Check if item exists
    - Remove(item) - Remove specific item
    - UnionWith(other) - Add items from another collection
    - IntersectWith(other) - Keep only common items
    - ExceptWith(other) - Remove items that exist in other
    - Clear() - Remove all items
    - Count - Get number of unique items
    - IsSubsetOf(other) - Check if all items exist in other collection
    - IsSupersetOf(other) - Check if contains all items from other collection
    
    CORE STACK METHODS TO RESEARCH:
    - Push(item) - Add item to top of stack
    - Pop() - Remove and return top item
    - Peek() - Look at top item without removing
    - Contains(item) - Check if item exists in stack
    - Clear() - Remove all items
    - Count - Get number of items
    - ToArray() - Convert to array (top item first)
    
    CORE QUEUE METHODS TO RESEARCH:
    - Enqueue(item) - Add item to back of queue
    - Dequeue() - Remove and return front item
    - Peek() - Look at front item without removing
    - Contains(item) - Check if item exists in queue
    - Clear() - Remove all items
    - Count - Get number of items
    - ToArray() - Convert to array (front item first)
    
    CORE SORTEDLIST METHODS TO RESEARCH:
    - Add(key, value) - Add key-value pair (auto-sorted by key)
    - [key] = value - Set or get value by key
    - ContainsKey(key) - Check if key exists
    - ContainsValue(value) - Check if value exists
    - Remove(key) - Remove key-value pair
    - RemoveAt(index) - Remove by position
    - IndexOfKey(key) - Get position of key
    - IndexOfValue(value) - Get position of value
    - Keys - Get all keys (sorted)
    - Values - Get all values (by key order)
    - Count - Get number of pairs
    - Capacity - Get allocated storage space
    
    ADDITIONAL RESEARCH RESOURCES:
    - Microsoft Docs: docs.microsoft.com/dotnet/api/system.collections.generic
    - C# Documentation: learn.microsoft.com/dotnet/csharp/
    - IntelliSense: Type the collection name and press Ctrl+Space for methods
    - Stack Overflow: stackoverflow.com (search for specific collection questions)
    - GitHub Examples: github.com (search for C# collection examples)
    
    ================================================================================
    */
}