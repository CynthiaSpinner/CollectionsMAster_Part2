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
            // 📋 WORKFLOW INSTRUCTIONS:
            // 1. FIRST: Create collection variables
            // 2. THEN: Scroll down to "START METHODS HERE" and implement the methods
            // 3. FINALLY: Come back here and call your methods
            // 4. Test each section by running the program
            
            #region HashSet
            Console.WriteLine("*** HASHSET ***");
            Console.WriteLine("=".PadRight(60, '='));
            Console.WriteLine("Stores unique items only, automatically prevents duplicates");

            // TODO: Create a HashSet with initial data (professional approach)
            // Example: HashSet<string> uniqueNames = new HashSet<string> {"John", "Jane", "John", "Mike"};
                        
            
            Console.WriteLine("\n2. HASHSET DISPLAY:");
            // TODO: Call DisplayHashSet() method and pass the HashSet
           
            
            Console.WriteLine("\n3. HASHSET COUNT & CONTAINS:");
            // TODO: Call CheckHashSetCount() method and pass the HashSet           
            

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF HASHSET SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            #region Stack
            Console.WriteLine("*** STACK ***");
            Console.WriteLine("=".PadRight(60, '='));
            Console.WriteLine("Last-In-First-Out (LIFO) like a stack of plates");

            // TODO: Create a Stack with initial data 
            // Example: Stack<int> numberStack = new Stack<int>(new[] {10, 20, 30});
                        
            
            Console.WriteLine("\n2. STACK DISPLAY:");
            // TODO: Call DisplayStack() method and pass the Stack
            
            
            Console.WriteLine("\n3. STACK POP:");
            // TODO: Call PopFromStack() method and pass the Stack
            

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF STACK SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            #region Queue
            Console.WriteLine("*** QUEUE ***");
            Console.WriteLine("=".PadRight(60, '='));
            Console.WriteLine("First-In-First-Out (FIFO) like a line at a store");

            Console.WriteLine("\n1. QUEUE CREATE & ENQUEUE:");
            // TODO: Create a Queue with initial data
            // Example: Queue<string> customerQueue = new Queue<string>(new[] {"Alice", "Bob", "Carol"});
            
            
            Console.WriteLine("\n2. QUEUE DISPLAY:");
            // TODO: Call DisplayQueue() method and pass the Queue
           
            
            Console.WriteLine("\n3. QUEUE DEQUEUE:");
            // TODO: Call DequeueFromQueue() method and pass the Queue
           

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF QUEUE SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion


            #region SortedList
            Console.WriteLine("*** SORTEDLIST ***");
            Console.WriteLine("=".PadRight(60, '='));
            Console.WriteLine("Key-value pairs kept automatically sorted by key");

            // TODO: Create a SortedList with initial data (out of order to show auto-sorting)
            // Example: SortedList<int, string> scoreBoard = new SortedList<int, string> {{3, "Charlie"}, {1, "Alice"}, {2, "Bob"}};
            

            Console.WriteLine("\n2. SORTEDLIST DISPLAY:");
            // TODO: Call DisplaySortedList() method and pass the SortedList
           
            
            Console.WriteLine("\n3. SORTEDLIST LOOKUP:");
            // TODO: Call LookupInSortedList() method and pass the SortedList
            

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF SORTEDLIST SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            Console.WriteLine("🎉 COLLECTIONS MASTER COMPLETE! 🎉");
            Console.ReadKey();
           
        }

        // ================================================================================
        // 🚀 START METHODS HERE! FOLLOW THIS WORKFLOW! 🚀
        // ================================================================================
        // 📋 STEP-BY-STEP INSTRUCTIONS:
        // 1. FIRST: Go back to Main() and create the collection variables
        // 2. THEN: Come back here and implement the methods below
        // 3. FINALLY: Go back to Main() and call your implemented methods
        // 4. Test each collection section by running the program
        // 5. Complete one collection at a time: HashSet → Stack → Queue → SortedList
        // ================================================================================

        // ============ HASHSET METHODS ============

        private static void DisplayHashSet(HashSet<string> uniqueNames)
        {
            // TODO: Print all unique names using a foreach loop
            Console.WriteLine("Unique Names, no duplicates: ");
            
                       
            // Notice: Even though "John" was added twice in the initializer, 
            // HashSet automatically removed the duplicate!            
        }

        private static void CheckHashSetCount(HashSet<string> uniqueNames)
        {
            // TODO: Print the count of unique names using .Count property 
            // Example: Console.WriteLine($"Number of unique names: {uniqueNames.Count}");
            
            
            // TODO: Check if specific names exist using Contains() method
            // Example: Console.WriteLine($"Contains John: {uniqueNames.Contains("John")}");
            // Example: Console.WriteLine($"Contains Bob: {uniqueNames.Contains("Bob")}"); //<--- returns true or false
            
        }

        // ============ STACK METHODS ============

        private static void DisplayStack(Stack<int> numberStack)
        {            
	        Console.WriteLine("Stack contents (top to bottom):");
            // TODO: Display all items in the stack without removing them using a foreach loop
            

                      
            
            // IMPORTANT: Understanding Stack Order
            // When we created: new Stack<int>(new[] {10, 20, 30})
            // Items were pushed in this order: 10 first, then 20, then 30
            // 
            // Stack looks like this (like stacking plates):
            // Imagine each element as a plate.
            // 10 gets placed on the table first
            // 20 gets placed on top of 10
            // 30 gets placed on top of 20
            // Leaving 30 on top, 20 in the middle and 10 on the bottom.            
        }

        private static void PopFromStack(Stack<int> numberStack)
        {
            Console.WriteLine("Popping from stack (LIFO order):");
            
            // TODO: Pop items one by one and display them using a while loop and Pop().
            // Example: while (numberStack.Count > 0)
            // Example: {
            // Example:     int item = numberStack.Pop();
            // Example:     Console.WriteLine($"Popped: {item}");
            // Example: }
         
            
            // Notice: Items come out in LIFO order (Last In, First Out)!
            // 30 comes out first (it was the last one pushed)
            // Then 20, then 10 (which was the first one pushed)
            //
            // ⚠️  IMPORTANT: Pop() REMOVES items from the stack!
            // After this method runs, the stack will be EMPTY!
            // This is different from foreach which just displays items.            
        }

        // ============ QUEUE METHODS ============

        private static void DisplayQueue(Queue<string> customerQueue)
        {
            // TODO: Display all items in the queue using a foreach loop
            Console.WriteLine("Queue contents (front to back):");
           
            
            // Notice: Queue displays from FRONT to BACK (Alice, Bob, Carol)
            // Alice is at the front (first to be served)
            // Carol is at the back (last to be served)            
        }

        private static void DequeueFromQueue(Queue<string> customerQueue)
        {
            // TODO: Remove items one by one and display them using Dequeue(), and a while loop with .Count
            Console.WriteLine("Serving customers (FIFO order):");
            // Example: while (customerQueue.Count > 0)
            // Example: {
            // Example:     string customer = customerQueue.Dequeue();
            // Example:     Console.WriteLine($"Serving: {customer}");
            // Example: }
           

            
            // Notice: Items come out in FIFO order (First In, First Out)!
            // Alice comes out first (she was first in line)
            // Then Bob, then Carol (who was last in line)
            //
            // ⚠️  IMPORTANT: Dequeue() REMOVES items from the queue!
            // After this method runs, the queue will be EMPTY!
            // This is different from foreach which just displays items.            
        }

        // ============ SORTEDLIST METHODS ============

        private static void DisplaySortedList(SortedList<int, string> scoreBoard)
        {
            Console.WriteLine("Scoreboard (automatically sorted by position):");

            // TODO: Display all key-value pairs using a foreach loop        
            // Example: foreach (var entry in scoreBoard) <--- using var for multiple types(int, string)
            // Example:     Console.WriteLine($"  Position {entry.Key}: {entry.Value}");
           
            
            // Notice: Even though we added items out of order (3, 1, 2),
            // SortedList automatically sorted them by key: 1, 2, 3            
        }

        private static void LookupInSortedList(SortedList<int, string> scoreBoard)
        {
	        Console.WriteLine("Looking up specific positions:");
            // TODO: Look up specific keys and check if keys exist
            // Example: if (scoreBoard.ContainsKey(1))
            // Example:     Console.WriteLine($"1st place: {scoreBoard[1]}");            


            // TODO: Check for key that doesn't exist.
 	        // Example: Console.WriteLine($"Contains position 5: {scoreBoard.ContainsKey(5)}"); <-- returns true or false         
                      

            // Notice: SortedList allows fast key-based lookups like Dictionary,
            // but keeps items sorted by key automatically!            
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

/*
    REAL-WORLD EXAMPLES: When to use these collections over Array, List, or Dictionary

    1. HashSet<T>
        - Use when you need to store a collection of unique items and don't care about order.
        - Real-world example: 
            * Tracking unique email addresses that have signed up for a newsletter (no duplicates allowed).
            * Keeping a set of unique tags or categories in a blog platform.
            * Checking for duplicate entries quickly (membership test is very fast).

    2. Stack<T>
        - Use when you need Last-In-First-Out (LIFO) behavior.
        - Real-world example:
            * Undo/Redo functionality in text editors (last action undone first).
            * Navigating browser history (back button).
            * Evaluating expressions in calculators (postfix notation).

    3. Queue<T>
        - Use when you need First-In-First-Out (FIFO) behavior.
        - Real-world example:
            * Print job management (first document sent is printed first).
            * Customer service ticketing systems (first customer in line is served first).
            * Task scheduling (process tasks in the order they arrive).

    4. SortedList<TKey, TValue>
        - Use when you need key-value pairs that are always sorted by key.
        - Real-world example:
            * Leaderboards in games (scores sorted by player ID or score).
            * Phonebook/contact list sorted by name or number.
            * Scheduling events by date/time where you need fast lookup and sorted order.

    Why not just use Array, List, or Dictionary?
        - Arrays/Lists allow duplicates and don't enforce uniqueness (unlike HashSet).
        - Arrays/Lists don't provide fast membership tests for large data (HashSet is much faster).
        - Dictionary doesn't maintain order (SortedList keeps keys sorted).
        - Arrays/Lists don't provide LIFO/FIFO behavior (Stack/Queue are specialized for these).
*/
}