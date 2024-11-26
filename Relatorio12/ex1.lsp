(defun process-list (lst)
  (mapcar (lambda (x)
            (if (>= x 4)
                (* x x)
                (/ x 2.0)))
          lst))

(let* ((list1 '(1 2 3))
       (list2 '(4 5 6))
       (result1 (process-list list1))
       (result2 (process-list result2))) 
       (finalresult) ---ajuste
