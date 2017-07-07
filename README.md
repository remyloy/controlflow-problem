# controlflow-problem

The project in this repository demonstrates the same application in three different flavors.
Every application should display the most basic linear graph (y = x) in a chart.
Both buttons should add a new data point to the chart.

The first sample is used to show the underlying problem of side-effectful programming.
Try pushing the buttons in any order and sometimes you should not a break in the otherwise linear graph.

The second sample fixes the problem by introducing seperate types in the method signatures to enforce the correct order.

The third sample reduces the number of types to a necessary minimum and shows a more pragmatic way.
