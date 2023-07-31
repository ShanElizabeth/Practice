# Q1
You have a 2D binary matrix that's filled with 0s and 1s. In the matrix, find the largest square that contains only 1s and return its area.

**Example**

For the following matrix:

cssCopy code

`matrix = [    ['1', '0', '1', '1', '1'],
    ['1', '0', '1', '1', '1'],
    ['1', '1', '1', '1', '1'],
    ['1', '0', '0', '1', '0'],
    ['1', '0', '0', '1', '0']
]` 
![image](https://github.com/shan-mulgrew/practice/assets/42028485/19ae9162-c0b3-41a4-90ee-70b6d534b945)

the output should be `solution(matrix) = 9`.

**Input/Output**

-   [execution time limit] 0.5 seconds (cs)
-   [memory limit] 1 GB

**[input] array.array.char matrix**

Guaranteed constraints:

-   0 ≤ matrix.length ≤ 100,
-   1 ≤ matrix[i].length ≤ 100,
-   0 ≤ matrix[i][j] ≤ 1.

**[output] integer**

An integer that represents the area of the largest square in the given matrix that is composed only of 1s.


-----
# Q2
Consider several points lying on a straight line. Call an unordered triple of points an _equidistant triple_ if one of them is the mid-point of the segment formed by the other two.

Given the coordinates of the points, find the number of equidistant triples formed by them.

Example

For `coordinates = [1, 2, 4, 6, 7, 8]`, the output should be  
`solution(coordinates) = 4`.

The equidistant triples are: `(1, 4, 7), (2, 4, 6), (4, 6, 8), (6, 7, 8)`.

Check out the image below for better understanding:

![](https://ci3.googleusercontent.com/proxy/mjTrxKqUK9IXPM1YGfO0VFgljKfZa6NEIhay9Qewd3ZyDoU24FJe-DzMNNET9kjSw6XtrlJc4ybyXm-JJ9wKPcMPGO-3XLJQFSYI0j-zA3WqQojgWKAeCjiAsZMA9g=s0-d-e1-ft#https://codesignal.s3.amazonaws.com/uploads/1664318515/example.png?raw=true "example")

Input/Output

-   [execution time limit] 0.5 seconds (cs)
    
-   [memory limit] 1 GB
    
-   [input] array.integer coordinates
    
    Sorted array of distinct integers.
    
    _Guaranteed constraints:_  
    `2 ≤ coordinates.length ≤ 2500`,  
    `-10000 ≤ coordinates[i] ≤ 10000`.
    
-   [output] integer
