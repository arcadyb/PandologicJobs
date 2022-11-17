
function ToGoogle(dtApi) {
    var data = new google.visualization.DataTable();
    ["", "Cumulative job views", "Cumulative predicted job views", "Active jobs"]
    data.addColumn('string', 'Date');
    data.addColumn('number', 'Cumulative job views');
    data.addColumn('number', 'Cumulative predicted job views');
    data.addColumn('number', 'Active jobs');
    dtApi.forEach(element => {
        console.log(element)
        data.addRow([element[0], parseInt(element[1]), parseInt(element[2]), parseInt(element[3])]);
    });


    console.log('ToGoogle : ' + data);
    return data;
}
export const Actions = {
 
    async ['getPageJobs'] ({ commit }, { pageNum }) {

        console.log('getPageJobs pageNum: ' +  pageNum);
        try{
        const furl = 'Jobs/?pageId='+ pageNum;
            const Response = await fetch(furl);
            if (Response.ok) {
                Response.json().then((data) => {
                    if (Response.ok) {
                        const googledata = ToGoogle(data.dataTable);

                        commit('SET_CHART_DATA', { page: pageNum, data: googledata });

                    }
                    else {
                        commit('SET_CHART_ERROR', { error: data });
                        console.log(data);
                    }

                });
            }
            else {
                commit('SET_CHART_ERROR', { Response });
                console.log(Response);
            }
        }
        catch(error)
        {
            commit('SET_CHART_ERROR', { error: error });
            console.log(error); 
        }

    },
     
};
