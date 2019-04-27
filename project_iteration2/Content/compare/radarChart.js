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
                label: 'Gallery 1',
                /* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                backgroundColor: "transparent", !!!!!!
                backgroundColor: "rgba(75,192,92,0.4)",
                borderColor: "rgba(75,192,192,1)",*/
                lineTension: 1,
                borderWidth: 3,
                pointHoverBorderWidth: 8,
                pointHoverBackgroundColor: "rgba(255,255,255,0)",
                /* IF PAGE BACKGROUND HAS COLORS --- pointHoverBorderColor: "rgba(255,255,255,0)", */
                data: [2,2,3,5],
                pointLabelFontSize: 50,
            },
            {
                label: 'Gallery 2',
                backgroundColor: "#949FB1",
                borderColor: "#97BBCD",
                lineTension: 1,
                borderWidth: 3,
                pointHoverBorderWidth: 8,
                pointHoverBackgroundColor: "rgba(255,255,255,0)",
                /* IF PAGE BACKGROUND HAS COLORS --- pointHoverBorderColor: "rgba(255,255,255,0)",*/
                data: [1,5,2,3]
            }
        ]
    },
    options: {
        responsive: false,
        maintainAspectRatio: true,
        title: {
            display: true,
            text: "Ratings of Each Gallery Under Different Criteria",
            fontSize: 16
        },
        label: {
            fontColor: "rgba(75,192,192,1)",
        },
        legend: {
            position: 'bottom',
            onClick: false,
        },
        scale: {
            ticks: {
                beginAtZero: true,
                max: 5,
                maxTicksLimit: 5,
                display: true,
                backdropColor: 'transparent',
            },
            gridLines: {
                circular: true, /* THIS DOES NOT WORK FML........ */
                lineWidth: 0.6,
            },
            labels: {
                padding: 20,
            },
            pointLabels :{
                fontSize: 12,
            },
        }
    },
    
    
});

radarChart.update();