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

            Console.WriteLine("\n1. HASHSET CREATE & ADD:");
            // TODO: Create a HashSet with initial data (professional approach)
            // Example: var uniqueNames = new HashSet<string> {"John", "Jane", "John", "Mike"};
            var uniqueNames = new HashSet<string> {"John", "Jane", "John", "Mike"};
            
            
            Console.WriteLine("\n2. HASHSET DISPLAY:");
            // TODO: Call DisplayHashSet() method and pass the HashSet
            DisplayHashSet(uniqueNames);
            
            Console.WriteLine("\n3. HASHSET COUNT & CONTAINS:");
            // TODO: Call CheckHashSetCount() method and pass the HashSet
            CheckHashSetCount(uniqueNames);
            

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF HASHSET SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            #region Stack
            Console.WriteLine("*** STACK ***");
            Console.WriteLine("=".PadRight(60, '='));
            Console.WriteLine("Last-In-First-Out (LIFO) like a stack of plates");

            Console.WriteLine("\n1. STACK CREATE & PUSH:");
            // TODO: Create a Stack with initial data 
            // Example: var numberStack = new Stack<int>(new[] {10, 20, 30});
            var numberStack = new Stack<int>(new[] {10, 20, 30});            
            
            Console.WriteLine("\n2. STACK DISPLAY:");
            // TODO: Call DisplayStack() method and pass the Stack
            DisplayStack(numberStack);
            
            Console.WriteLine("\n3. STACK POP:");
            // TODO: Call PopFromStack() method and pass the Stack
            PopFromStack(numberStack);

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF STACK SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            #region Queue
            Console.WriteLine("*** QUEUE ***");
            Console.WriteLine("=".PadRight(60, '='));
            Console.WriteLine("First-In-First-Out (FIFO) like a line at a store");

            Console.WriteLine("\n1. QUEUE CREATE:");
            // TODO: Call CreateQueue() method and store result in a variable
            // Implement the CreateQueue() method at bottom of file
            
            Console.WriteLine("\n2. QUEUE ENQUEUE:");
            // TODO: Call EnqueueToQueue(queue) method
            // Implement the EnqueueToQueue() method at bottom of file
            
            Console.WriteLine("\n3. QUEUE DEQUEUE:");
            // TODO: Call DequeueFromQueue(queue) method
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
            // TODO: Call CreateSortedList() method and store result in a variable
            // Implement the CreateSortedList() method at bottom of file
            
            Console.WriteLine("\n2. SORTEDLIST ADD:");
            // TODO: Call AddToSortedList(sorted) method
            // Implement the AddToSortedList() method at bottom of file
            
            Console.WriteLine("\n3. SORTEDLIST DISPLAY:");
            // TODO: Call DisplaySortedList(sorted) method
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

        private static void DisplayHashSet(HashSet<string> uniqueNames)
        {
            // TODO: Print all unique names using a foreach loop
            Console.WriteLine("Unique Names, no duplicates: ");
            
            foreach (string names in uniqueNames)
            {
                Console.WriteLine(names);
            }
            
            // Notice: Even though "John" was added twice in the initializer, 
            // HashSet automatically removed the duplicate!
            
        }

        private static void CheckHashSetCount(HashSet<string> uniqueNames)
        {
            // TODO: Print the count of unique names using .Count property 
            Console.WriteLine($"Number of unique names: {uniqueNames.Count}");
            
            
            // TODO: Check if specific names exist using Contains() method
            // Example: Console.WriteLine($"Contains John: {uniqueNames.Contains("John")}");
            // Example: Console.WriteLine($"Contains Bob: {uniqueNames.Contains("Bob")}");
            Console.WriteLine($"Contains John: {uniqueNames.Contains("John")}");
            Console.WriteLine($"Contains Bob: {uniqueNames.Contains("Bob")}");
        }

        // ============ STACK METHODS ============

        private static void DisplayStack(Stack<int> numberStack)
        {
            // TODO: Display all items in the stack without removing them
            // Example: Console.WriteLine("Stack contents (top to bottom):");
            // Example: foreach (int number in numberStack)
            // Example:     Console.WriteLine($"  {number}");
            
            // Notice: Stack displays from top to bottom (30, 20, 10)
            // The last item pushed (30) is at the top!
            
        }

        private static void PopFromStack(Stack<int> numberStack)
        {
            Console.WriteLine("Popping from stack (LIFO order):");
            
            // TODO: Pop items one by one and display them
            // Example: while (numberStack.Count > 0)
            // Example: {
            // Example:     int item = numberStack.Pop();
            // Example:     Console.WriteLine($"Popped: {item}");
            // Example: }
            
            // Notice: Items come out in reverse order (30, 20, 10)!
            
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