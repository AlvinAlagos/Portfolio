





window.onload = () => {
    let button = document.querySelector("#btn");
    button.addEventListener("click", calculate);
};
  
function calculate() {
  
    let height = document.querySelector("#height").value;
    let weight = document.querySelector("#weight").value;  
    let result = document.querySelector("#result");
  
 
    if (height === "" || weight === "") 
	result.innerHTML = "Input either empty or invalid";
  
    else {
        let bmi = (weight / ((height * height)/ 10000)).toFixed(2);
            result.innerHTML = `*Your BMI weight is: <span>${bmi}</span>`;
    }
}