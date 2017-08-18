# Fractal Tree
A recursive  algorithm for draw a fractal tree.
Explaniation:
1) Draw a vertical line.
2) Draw a sub-line with an orientation of a theta angle
3) Then the recursivity does all the work

In my code i considered some variables like:

-) Depth: This var works for know the level of the fractal tree and i used it to create the base case.

-) Angle: This var save the orientation angle of the lines

If you look at my code, yo will observate that in the formulas for find Yf and Xf, I multiplicated sin(angle) or cos(angle) (depends of cartesian component)* depth and a length, that length is for enlarge the lines. If you ask yourself why I sum to xo and yo (for find Xf, Yf): sin(angle) or cos(angle) (depends of cartesian component) * length * depth, this is because it's a vector points that start in the origin  (I look the line like a vector) and I traslate the vector for actual origin points (xo,yo).
PST: I locked the depth level to 20, you can modify it in design panel.
