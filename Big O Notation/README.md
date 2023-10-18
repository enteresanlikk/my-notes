# Big O Notation

- !!! It's not a time, it's an operation!!!
- Fixed numbers and multiples can be ignored. 
- Time complexity is important but space complexity should not be skipped. If space complexity is skipped, the application will crash.

- O(1) – Constant Time - Excellent
    - Where is it used?
        1.	Lookup bu index for array
        2.	Inserting a node to beginning/end of singly linkedlist
        3.	Push/pop on a stack
        4.	Enqueue/Dequeue on a queue
        5.	Insert/remove/lookup on a hash map
        6.	Insert/remove/containsKey on a has set
- O(log n) – Logarithmic Time - Good
    - Where is it used?
        1.	Insert/remove/lookup for binary tree
        2.	Many divide and conquer algorithms
- O(n) - Linear Time - Fair
    - Where is it used?
        1.	 Lookup by value for an array
        2.	Insert/remove on an array
        3.	Lookup by value/index on a linked list
        4.	Insert in the middle on a singly linked list
        5.	Remove from the middle/end from a singly linked list
        6.	Linear search
        7.	Count sort
        8.	Bucket sort
        9.	Comparing two strings
- O(n log n)  - Loglinear Time - Bad
    - Where is it used?
        1.	Merge sort
        2.	Quick sort
- O(np) - Polynomial Time - **Terrible** 
    - Types
        1.	O(n2) - Quadratic
        2.	O(n3) - Cubic
        3.	O(n4) - Quadric
    - Where is it used?
        1.	Nested for loops
        2.	Bubble sort
        3.	Selection sort
        4.	Insertion sort
- O(2n) – Exponential Time - **Terrible** 
    - Not common
    - Avoid to get it!
    - Tower of Hanoi
    - Examples
        1.	Chess (264)
        2.	Lake filled with stones problem
- O(n!) - Factorial Time - **Terrible** 
    - Avoid to get it!