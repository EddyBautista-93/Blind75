using System;
using System.Collections.Generic;
using System.Collections;
public class LinkedListNotes
{
    /*
    A linked list is a linear data structure which stores elements in a non-contiguous location. 
    The elements are linked with each other using pointers.
    LinkedList consit of nodes where each note contains a data field and reference to
    the next node in the list. 

    In C# LinkedList is the generic type collection which is denfined in System.Collections.Generic namespace.
    It is doubly linked list, therefore, each node points forwards to the next node
    and backwards to the previous node. 
    It is a dynamic collection which grows, according to the need of the program. 
    It provides fast inserting and removing of elements. 

                     Head
                              +------+-------+-----+      Next         +-----+-------+--------+    Next      +------+------+-------+       Null
                              |      |       |     |                   |     |       |        |              |      |      |       |
                    --------> |      |       |     +-----------------> |     |       |        +------------> |      |      |       |  ----------->
                              |      |       |     |                   |     |       |        |              |      |      |       |
                              |      |       |     |                   |     |       |        |              |      |      |       |
                              |      |       |     |                   |     |       |        |              |      |      |       |
                              |      |   A1  |     |                   |     |   A2  |        |              |      |  A3  |       |
                              |      |       |     |                   |     |       |        |              |      |      |       |
                              |      |       |     |                   |     |       |        |              |      |      |       |
                     <------- |      |       |     |  <----------------+     |       |        |  <-----------+      |      |       |
                              |      |       |     |                   |     |       |        |              |      |      |       |
                     Null     +------+-------+-----+      Prev         +-----+-------+--------+   Prev       +------+------+-------+

    Important Points
    -- The LinkedList class implements the ICollection<T>, IEnumerable<T>, IReadOnlyCollection<T>, ICollection, IEnumerable, IDeserializationCallback, and ISerializable interfaces.
    -- It also supports enumerators.
    -- You can remove nodes and reinsert them, either in the same list or in another list, which results in no additional objects allocated on the heap.
    -- Every node in a LinkedList<T> object is of the type LinkedListNode<T>.
    -- It does not support chaining, splitting, cycles, or other features that can leave the list in an inconsistent state.
    -- If the LinkedList is empty, the First and Last properties contain null.
    -- The capacity of a LinkedList is the number of elements the LinkedList can hold.
    -- In LinkedList, it is allowed to store duplicate elements but of the same type.

    
    
    */
    
    
}