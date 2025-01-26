# F# Mutable Variable Swap Unexpected Behavior

This example demonstrates a common misunderstanding in F# regarding mutable variables and pass-by-reference semantics.  The `swap` function appears to swap the values of `x` and `y`, but due to the nature of mutable variables in F#, it modifies the original variables directly.

## Bug
The `bug.fs` file shows the code that produces unexpected results. The expected output is `10 20`, but the actual output is `20 20`.

## Solution
The `bugSolution.fs` demonstrates how to correctly swap variables while avoiding the issues related to pass-by-reference.  We now create copies of x and y before swapping them. 

This clarifies the behavior of mutable variables in F# and how to handle them correctly.