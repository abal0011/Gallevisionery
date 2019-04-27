/* CHANGE THIS TO A FOR LOOP TO FETCH DATA LATER */

/* RADAR CHART SCRIPT */

const CHART2 = document.getElementById("radarChart");
console.log(CHART2);
let radarChart = new Chart(CHART2, {
    type: 'radar',
    data: {
        labels: ["Entertainment", "Foot Traffic", "Transportation", "Accessibility"],
        datasets: [
            {
                label: 'Rating of this gallery out of 5',
                backgroundColor: "rgba(75,192,92,0.4)",
                borderColor: "rgba(75,192,192,1)",
                borderWidth: 2,
                data: [2,2,3,3,5],
            }
        ]
    },
    options: {
        responsive: false,
        maintainAspectRatio: this.maintainAspectRatio,
    }
});


