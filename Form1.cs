namespace RegressionAnalyzer
{
    public partial class Form1 : Form
    {
        private int n;
        private List<double> xValues = new List<double>();
        private List<double> yValues = new List<double>();

        private double xMean, yMean, slope, intercept;
        private double sst = 0, sse = 0, ssr = 0;
        private double mse, sd, msr;
        private double rSquared, r;
        private double fStatistic, df1 = 1, df2;

        private bool isSyncingSelection = false;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // run button click event handler
            string inputX = tbX.Text;
            string inputY = tbY.Text;

            // verify inputs are not empty
            if (inputX == "" || inputY == "")
            {
                MessageBox.Show("Please enter values for X and Y.");
                return;
            }

            // split inputs into arrays
            string[] xParts = inputX.Split(' ');
            string[] yParts = inputY.Split(' ');
            n = xParts.Length;

            // verify both inputs have the same number of values
            if (yParts.Length != n)
            {
                MessageBox.Show("The number of X and Y values must be the same.");
                return;
            }

            // store values in lists
            // check if inputs are valid numbers
            try
            {
                xValues.AddRange(xParts.Select(double.Parse));
                yValues.AddRange(yParts.Select(double.Parse));

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for X and Y.");
                return;
            }

            simpleRegressionModelLoad();
        }

        private void simpleRegressionModelLoad()
        {
            switchToModelPanel();

            // display sample data on grid
            for (int i = 0; i < n; i++)
            {
                gridSample.Rows.Add(xValues[i], yValues[i]);
            }

            // calculate means
            xMean = Math.Round(xValues.Average(), 2);
            yMean = Math.Round(yValues.Average(), 2);

            lblXMean.Text = xMean.ToString();
            lblYMean.Text = yMean.ToString();

            // calculate equation and intermediary values
            calculateModel(calculateModelIntermediates());

            // calculate fitness of model
            calculateModelFitness();

            calculateFStatistic();
        }

        private double[] calculateModelIntermediates()
        {
            double xyDiffProductSum = 0;
            double xDiffSquaredSum = 0;

            for (int i = 0; i < n; i++)
            {
                // calculate intermediary values
                double xDiff = xValues[i] - xMean;
                double yDiff = yValues[i] - yMean;
                double xyDiffProduct = xDiff * yDiff;
                double xDiffSquared = xDiff * xDiff;

                // add intermediary values to grid
                gridModelIntermediate.Rows.Add(
                    Math.Round(xDiff, 2),
                    Math.Round(yDiff, 2),
                    Math.Round(xyDiffProduct, 2),
                    Math.Round(xDiffSquared, 2)
                );

                // accumulate sums
                xyDiffProductSum += xyDiffProduct;
                xDiffSquaredSum += xDiffSquared;
            }

            // display sums
            lblXYDiffProductSum.Text = Math.Round(xyDiffProductSum, 2).ToString();
            lblXDiffSquaredSum.Text = Math.Round(xDiffSquaredSum, 2).ToString();

            return new double[] { xyDiffProductSum, xDiffSquaredSum };
        }

        private void calculateModel(double[] intermediates)
        {
            // calculate slope
            slope = Math.Round(intermediates[0] / intermediates[1], 2);
            lblSlope.Text = slope.ToString();

            // calculate intercept
            intercept = Math.Round(yMean - (slope * xMean), 2);
            lblIntercept.Text = intercept.ToString();

            // display regression equation
            lblRegressionEQ.Text = $"y = {intercept} + {slope}x";
        }

        private void calculateModelFitness()
        {
            // predict y values and residuals
            for (int i = 0; i < n; i++)
            {
                double y = yValues[i];

                double predictedY = predictY(xValues[i]);
                double dataVar = calculateDataVariation(y);
                double unexplainedVar = calculateUnexplainedVariation(y, predictedY);
                double explainedVar = calculateExplainedVariation(predictedY);
                gridModelFitness.Rows.Add(predictedY, dataVar, unexplainedVar, explainedVar);

                // accumulate sums for fitness
                sst += dataVar;
                sse += unexplainedVar;
                ssr += explainedVar;
            }

            // display sums for fitness
            sst = Math.Round(sst, 2);
            sse = Math.Round(sse, 2);
            double ssrIntermediate = Math.Round(ssr, 2);
            ssr = Math.Round(sst - sse, 2);

            lblSSTSum.Text = sst.ToString();
            lblSSESum.Text = sse.ToString();
            lblSSRSum.Text = ssrIntermediate.ToString();

            lblSST.Text = $"SST = {sst}";
            lblSSE.Text = $"SSE = {sse}";
            lblSSR.Text = $"SSR = {ssr}";

            // calculate coefficients
            rSquared = Math.Round(ssr / sst, 2);
            r = Math.Round(Math.Sqrt(rSquared), 2);

            lblCOD.Text = rSquared.ToString();
            lblCOE.Text = r.ToString();

            // calculate MSE and SD
            mse = Math.Round(sse / (n - 2), 2);
            sd = Math.Round(Math.Sqrt(mse), 2);
            msr = Math.Round(ssr / 1, 2);

            lblMSE.Text = mse.ToString();
            lblSD.Text = sd.ToString();
            lblMSR.Text = msr.ToString();
        }

        private void calculateFStatistic()
        {
            // calculate F-statistic value
            fStatistic = Math.Round(msr / mse, 2);
            lblFStat.Text = fStatistic.ToString();

            // calculate degrees of freedom
            df2 = n - 2;
            lblDF1.Text = df1.ToString() + " (col)";
            lblDF2.Text = df2.ToString() + " (row)";
        }

        private double predictY(double x)
        {
            return Math.Round(intercept + slope * x, 2);
        }
        private double calculateDataVariation(double y)
        {
            // for SST
            return Math.Round(Math.Pow(y - yMean, 2), 2);
        }
        private double calculateUnexplainedVariation(double y, double predictedY)
        {
            // for SSE
            return Math.Round(Math.Pow(y - predictedY, 2), 2);
        }
        private double calculateExplainedVariation(double predictedY)
        {
            // for SSR
            return Math.Round(Math.Pow(predictedY - yMean, 2), 2);
        }

        private void init()
        {
            pnlSimpleModel.Visible = false;
            pnlInput.Visible = true;
            msReset.Enabled = false;
        }
        private void switchToModelPanel()
        {
            pnlInput.Visible = false;
            pnlSimpleModel.Visible = true;
            msReset.Enabled = true;
        }

        private void msReset_Click(object sender, EventArgs e)
        {
            init();

            xValues.Clear();
            yValues.Clear();
            sst = sse = ssr = 0;
            df1 = 1;
            isSyncingSelection = false;

            tbXInput.Text = "";
            tbPredictedY.Text = "";

            gridSample.Rows.Clear();
            gridModelIntermediate.Rows.Clear();
            gridModelFitness.Rows.Clear();
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            if (isSyncingSelection) return;
            isSyncingSelection = true;

            DataGridView sourceGrid = (DataGridView)sender;

            if (sourceGrid.CurrentCell == null || sourceGrid.CurrentCell.RowIndex < 0)
            {
                isSyncingSelection = false;
                return;
            }

            int row = sourceGrid.CurrentCell.RowIndex;

            if (sourceGrid != gridSample && row < gridSample.Rows.Count)
            {
                gridSample.ClearSelection();
                gridSample.Rows[row].Selected = true;
            }

            if (sourceGrid != gridModelIntermediate && row < gridModelIntermediate.Rows.Count)
            {
                gridModelIntermediate.ClearSelection();
                gridModelIntermediate.Rows[row].Selected = true;
            }

            if (sourceGrid != gridModelFitness && row < gridModelFitness.Rows.Count)
            {
                gridModelFitness.ClearSelection();
                gridModelFitness.Rows[row].Selected = true;
            }

            isSyncingSelection = false;
        }

        private void tbXInput_TextChanged(object sender, EventArgs e)
        {
            // get input x
            string inputX = tbXInput.Text;

            if (inputX == "")
            {
                tbPredictedY.Text = "";
                return;
            }

            double xValue;
            try
            {
                xValue = double.Parse(inputX);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for x.");
                return;
            }

            // predict y
            tbPredictedY.Text = predictY(xValue).ToString();
        }
    }
}
