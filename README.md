Weighted Strings
![image](https://github.com/imroatulfaizah/msbu/assets/23720075/2e56ec1a-e799-4095-8989-32c7ce4f3d33)

Balanced Bracket

![image](https://github.com/imroatulfaizah/msbu/assets/23720075/05c0e280-d461-442d-8e6a-5712c5ac3880)

Time Complexity: O(n)

The primary operation in the IsBalanced method is a single pass through the string s, which has a length of n.
For each character in the string, the code performs a constant number of operations: checking the character type ({, [, (, }, ], )), pushing to or popping from the stack, and comparing the top of the stack with the current character.
Since each of these operations takes constant time and there are n characters to process, the overall time complexity is linear, or O(n).
Space Complexity: O(n)

The space complexity is determined by the size of the stack used to keep track of the opening brackets.
In the worst-case scenario, all characters in the string are opening brackets ({, [, (), which means the stack could grow to a size of n before starting to pop elements off.
Therefore, the space complexity is also O(n), as the maximum amount of space needed is proportional to the length of the input string.
In summary, the code has a linear time complexity of O(n) because it processes each character in the input string exactly once. The space complexity is also O(n), as it depends on the number of opening brackets that might need to be stored in the stack in the worst case.

Highest Palindrome
![image](https://github.com/imroatulfaizah/msbu/assets/23720075/f33a5e20-2248-4e14-8262-1613f545f3c6)

