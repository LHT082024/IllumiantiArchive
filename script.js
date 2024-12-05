async function Login() {
    const username = document.getElementById("usernameFront").value;
    const password = document.getElementById("passwordFront").value;

    console.log(username, password)
    try {
        const response = await fetch("http://localhost:5118/api/login", {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify({ Username: username, Password: password })
        });

        const result = await response.json();

        if (response.ok) {
            alert("Login successful!");
            console.log(result);
            document.getElementById("status").innerText = `Welcome, ${result.user.Username}!`;
        } else {
            console.error("Error", result);
            alert(result.Message); // Display the error message sent from backend
        }
    } catch (error) {
        console.error("Error logging in:", error);
        document.getElementById("status").innerText = "An error occurred.";
    }
}

const userCredentials = { Username: "Snorre", Password: "ReykholtIsBae1179" };
fetch('http://localhost:5118/api/login', {
  method: 'POST',
  headers: {
    'Content-Type': 'application/json',
  },
  body: JSON.stringify(userCredentials)
})
.then(response => response.text())  // Get raw response as text first
.then(data => {
  console.log('Response:', data);  // Log the response to see what's returned
  return JSON.parse(data);         // Manually parse JSON
})
.catch(error => {
  console.error('Error logging in:', error);
});


fetch('http://localhost:5118/api/login', {
  method: 'POST',
  headers: {
    'Content-Type': 'application/json',
  },
  body: JSON.stringify(userCredentials)
})
.then(response => {
  if (!response.ok) {
    throw new Error('Network response was not ok');
  }
  return response.json();
})
.then(data => {
  console.log('Login successful:', data);
})
.catch(error => {
  console.error('Error logging in:', error);
});