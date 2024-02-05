 window.onload = () => {
            let button = document.querySelector('#btn');
            button.addEventListener("click", calculateBMI);
        }
        function calculateBMI() {
            let height = parseInt(document.querySelector('#height').value);
            let weight = parseInt(document.querySelector('#weight').value);
            let result = document.querySelector('#result');
            let bmi = document.querySelector('#valueofbmi');
            if (height === '' || isNaN(height))
                result.innerHTML = 'Provide a valid Height!';
            else if(weight === '' || isNaN(weight))
                result.innerHTML = 'Provide a valid height';
            else {
                let bmi = (weight / ((height*height)/10000)).toFixed(2);
                valueofbmi.innerHTML = `<span>${bmi}</span>`;
                if (bmi <18.5) {
                    result.innerHTML = ` Underweight`;
                }
                else if(bmi >= 18.5 && bmi < 25) {
                    result.innerHTML = ` Normal`;
                }
                else {
                    result.innerHTML = ` Overweight`
                }
            }
        }