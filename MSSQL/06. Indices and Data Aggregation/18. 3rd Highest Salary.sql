SELECT DISTINCT DepartmentID,
                Salary
             AS ThirdHighestSalary   
           FROM (
                 SELECT DepartmentID,
                        Salary, 
                        DENSE_RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC)
                     AS SalaryRank  
                   FROM Employees
                ) AS Ranked
          WHERE SalaryRank = 3