## Mini Learning Management
	Description:
	Create a Windows Forms application for a teacher.
	The teacher logs in using:
		-User ID: Teacher
		-Password: Admin
	
	If the login is correct, the Student Management form opens.
	The teacher can:
		-Add a student
		-View students
		-Delete a student
		-Save the student with the highest GPA to a text file
		-Log out

## Student Information
	Create a Student class with these properties:
		-StudentId
		-StudentName
		-Gpa
	
	A BindingList<Student> is useful when displaying students in a DataGridView.

## Workflow
	- create a userID that contains "Teacher" and password "Admin"
	- then checks whether those login and user matches what in the system by validating it
	- the user then selects login to to open another form
	- opens another form that shows mini learning management for Teacher Role
	- the teacher can add StudentID, StudentName, GPA and can use any generic list to save students
	- there will be a txtbox Student ID that only contains int and
	- validate it that doesn't contain any string
	- txtbox below will be student name validating it that it only contains string
	- ignoring any number and Caps error
	- txtbox GPA can only contain double in 0.00 format 
	- validate it that doesn't contain any string
	- bind all those txtbox to add button
	- the button then saves the student information in any generic lists and writes in the text file
	- then the teacher can select on the grid view to and select delete button to delete student
	- the delete would then remove the student on the lists and delete the student from the text file
	- then it would have a logout button to bring back to the first form
	- ?? if the teacher login again then it would be able to see the saved information (databases needed)