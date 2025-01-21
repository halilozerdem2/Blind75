Explanation

Dictionary (Hash Map):
The dictionary is used to store numbers as keys and their indices as values.
This allows O(1) average time complexity for lookups.

Algorithm:
For each number in the array, calculate the complement as target - nums[i].
Check if the complement exists in the dictionary:
If yes, return the indices of the current number and the complement.
If no, store the current number and its index in the dictionary.


Edge Cases:
The problem guarantees exactly one solution, so no need to handle cases where there is no solution.

Time Complexity
Hash Map Lookup: O(1) on average.
Iteration Through Array: O(n).
Overall Time Complexity: O(n).

Space Complexity
Dictionary Storage: O(n) in the worst case if all numbers are unique.
This approach is efficient and meets the requirements of the follow-up by reducing the time complexity to less than O(n²).