Feature: Login
 In order to access my account
    As a user of the website
   I want to log into the website

@tag1

Scenario Outline: Successful Login with Valid Credentials
    Given the UserId is Salini 
    And the password is Shalu@123
    When UserClicksLogin
    Then LoginMessage should be Successfully Loggedin

Scenario: Successful LogOut
    When User LogOut from the Application
    Then Logoutmessage should be Successful Logged Out



   
    
