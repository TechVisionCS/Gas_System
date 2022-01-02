'use strict';
$(document).ready(function() {

    // chart js function start
    function buildchartoption() {
        return {
            title: {
                display: !1
            },
            tooltips: {
                enabled: true,
                intersect: !1,
                mode: "nearest",
                xPadding: 10,
                yPadding: 10,
                caretPadding: 10
            },
            legend: {
                display: !1,
                labels: {
                    usePointStyle: !1
                }
            },
            responsive: !0,
            maintainAspectRatio: !0,
            hover: {
                mode: "index"
            },
            scales: {
                xAxes: [{
                    display: !1,
                    gridLines: !1,
                    scaleLabel: {
                        display: !0,
                        labelString: "Month"
                    }
                }],
                yAxes: [{
                    display: !1,
                    gridLines: !1,
                    scaleLabel: {
                        display: !0,
                        labelString: "Value"
                    },
                    ticks: {
                        beginAtZero: !0
                    }
                }]
            },
            elements: {
                point: {
                    radius: 4,
                    borderWidth: 12
                }
            },
            layout: {
                padding: {
                    left: 0,
                    right: 0,
                    top: 0,
                    bottom: 0
                }
            }
        };
    }
    // chart js function end



 
    // statustic end

    // feedback chart start
    var ctx = document.getElementById("feedback-chart").getContext("2d");
    var config = {
        type: 'doughnut',
        data: {
            datasets: [{
                data: [
                    83, 17,
                ],
                backgroundColor: [
                    "#4099ff",
                    "#81c1fd"
                ],
                label: 'Dataset 1',
                borderWidth: 0
            }],
            labels: [
                "Positive",
                "Negative"
            ]
        },
        options: {
            responsive: true,
            legend: {
                display: false,
            },
            title: {
                display: false,
                text: 'Chart.js Doughnut Chart'
            },
            animation: {
                animateScale: true,
                animateRotate: true
            }
        }
    };
    window.myDoughnut = new Chart(ctx, config);
    // feedback chart end

    // seo card start
    function seojs(a, b, f) {
        if (f == null) {
            f = "rgba(0,0,0,0)";
        }
        return {
            labels: ["1", "2", "3", "4", "5", "6", "7"],
            datasets: [{
                label: "",
                borderColor: a,
                borderWidth: 2,
                hitRadius: 0,
                pointHoverRadius: 0,
                pointRadius: 3,
                pointBorderWidth: 2,
                pointHoverBorderWidth: 12,
                pointBackgroundColor: Chart.helpers.color("#fff").alpha(1).rgbString(),
                pointBorderColor: Chart.helpers.color(a).alpha(1).rgbString(),
                pointHoverBackgroundColor: a,
                pointHoverBorderColor: Chart.helpers.color("#000000").alpha(0).rgbString(),
                fill: true,
                backgroundColor: f,
                data: b,
            }]
        };
    }
    var ctx = document.getElementById('seo-card1').getContext("2d");
    var gradientFill = ctx.createLinearGradient(300, 0, 0, 300);
    gradientFill.addColorStop(1, "#b9fdef");
    gradientFill.addColorStop(0, "#2ed8b6");
    var myChart = new Chart(ctx, {
        type: 'line',
        data: seojs('#2ed8b6', [100, 80, 100, 150, 190, 200, 160], gradientFill),
        options: buildchartoption(),
    });
    var gradientFill = ctx.createLinearGradient(300, 0, 0, 300);
    gradientFill.addColorStop(1, "#b5d8ff");
    gradientFill.addColorStop(0, "#4099ff");
    var ctx = document.getElementById('seo-card2').getContext("2d");
    var myChart = new Chart(ctx, {
        type: 'line',
        data: seojs('#4099ff', [100, 80, 100, 150, 190, 200, 160], gradientFill),
        options: buildchartoption(),
    });
    // seo cardunction end

});
