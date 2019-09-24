/// A 2 dimension vector library
/// Vectors are represented as pairs of floats

module vec2d
/// The length of a vector
let len ((x1, y1) : float*float) : float = sqrt (x1 ** 2.0 + y1 ** 2.0)
/// The angle of a vector
let ang ((x1, y1) : float*float) : float = atan2 y1 x1
/// Multiplication of a float and a vector
let scale (c : float) ((x1, y1) : float*float) : float*float = (x1 * c, y1 * c)
/// Addition of two vectors
let add ((x1, y1) : float*float) ((x2, y2) : float*float) : float*float = (x1 + x2, y1 + y2)
/// Dot product of two vectors
let dot ((x1, y1) : float*float) ((x2, y2) : float*float) : float = (x1*x2 + y1*y2)