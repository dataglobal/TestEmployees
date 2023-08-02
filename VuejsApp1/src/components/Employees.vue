<template>
    <div class="container">
        <div class="card" style="width: 100%;">
            <h3 class="card-title">Employees List</h3>
            <div class="card-body">
                <p class="card-text">
                    <div class="row">
                        <div class="col-sm-9">
                            <label for="EmployeeId" class="form-label">Employee Id</label>
                            <input type="number" class="form-control" id="EmployeeId" placeholder="Enter Employee Id" 
                                  v-model="this.id" >
                        </div>
                        <div class="col-sm-3" style="padding-top:25px; text-align:right;">
                            <button @click.prevent="searchById" class="btn btn-primary">Search</button>
                        </div>
                    </div>
                    <br />
                    <br />
                    <div class="mb-3">
                        <table class="table">
                            <thead>
                                <tr>
                                    <th scope="col">#</th>
                                    <th scope="col">Name</th>
                                    <th scope="col">Age</th>
                                    <th scope="col">Salary</th>
                                    <th scope="col">Anualy Salary</th>

                                </tr>
                            </thead>
                            <tbody v-for="employee in this.employees">
                                <tr>
                                    <th scope="row">{{employee.id}}</th>
                                    <td>{{employee.employeeName}}</td>
                                    <td>{{employee.employeeAge}}</td>
                                    <td>{{employee.employeeSalary}}</td>
                                    <td>{{employee.anualSalary}}</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </p>

            </div>
        </div>
    </div>

</template>
<script>
    import axios from 'axios';
    export default {
        name: 'Employees',
        data() {
            return {
                id: null,
                employees: []
            }
        },
        methods: {
            searchById() {
                let url = '';
                if (this.id== null || this.id == "") {
                    url = 'https://localhost:7122/api/Employees/with-salary';
                } else {
                    url = 'https://localhost:7122/api/Employees/' + this.id;
                }
                console.log(url);
                axios
                    .get(url)
                    .then(result => {
                        this.employees = result.data;
                        console.log("emp", result.data);
                        this.id = "";
                    })
                    .catch(error => console.log('error', error));
            }
        }
    }
</script>