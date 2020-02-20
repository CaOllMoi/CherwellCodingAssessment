**Specifications : the coordinates are given in this order - clockwise starting from the right corner**

    odd columns
          (c2x,c2y)
              |\
              | \  
              |  \ 
              |___\    
       (c1x,c1y)   (c3x,c3y)

    even columns

    (c3x,c3y) ____  (c1x,c1y)
              \   |
               \  |
                \ | 
                 \| (c2x,c2y)


front end /view.html

**Question 1A**
----
    Calculate the triangle coordinates for an image with right triangles such that for a given
    row (A-F) and column (1-12)

* **URL**

  /api/TrianglesQuestion1A

* **Method:**

  `GET`
  
*  **URL Params**

   **Required:**
 
   `row=[string]`
   `col=[string]`

* **Response:**

  * **Content:** `(20,0) (20,10) (10,0)` in this order (c1x,c1y),(c2x,c2y),(c3x,c3y)
 
* **Error Response:**

    **Content:** `invalid input`

**Question 1B**
----
    given the vertex coordinates, calculate the row and column for the triangle. They are given in this order (c1x,c1y),(c2x,c2y),(c3x,c3y)

* **URL**

  /api/TrianglesQuestion1B

* **Method:**

  `GET`
  
*  **URL Params**
        
   **Required:**
 
    `c1x=[string]`
    `c1y=[string]`
    `c2x=[string]`
    `c2y=[string]`
    `c3x=[string]`
    `c3y=[string]`

* **Response:**

  * **Content:** `Row A - Column 1`  for example
 
* **Error Response:**

    **Content:** `invalid input`
