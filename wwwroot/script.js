async function Login() {
   const username = document.getElementById("usernameFront").value;
   const password = document.getElementById("passwordFront").value;

   try {
    const response = await fetch ("/api/login", {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify({Username: username, Password: password}),
    });

    const result = await response.json();

    if(response.ok) {
        alert("Login succesful!");
        console.log(result);
        document.getElementById("status").innerHTML = `Welcome, ${result.profiles.Username}!`;
         } else {
            console.error("Error", error);
            alert("Error occured")
        }
    } catch (error) {
        console.error("Error logging in:", error);
        document.getElementById("status").innerText = "An error occurred.";
    }
}

function changeColor() {
    document.getElementById("my-div").style.backgroundColor = "#00FF00";
}