<template>
    <div class="hello">
        <h1>{{ msg }}</h1>
     
        <button @click="update">update</button>
        <div>
            <ul>
                <li v-for="object in dict" :key="object.id">
                    <input type="checkbox" />
                    {{object.objectName}}:{{object.x}},{{object.y}}
                </li>
            </ul>
        </div>
    </div>
</template>

<script>
    import axios from 'axios'
    export default {
        props: {
            msg: String,
        },
        data: function () {
            return {
                dict: [],
            }
        },
        created: function () {
            this.update();
        },
        mounted: function () {
        },
        methods: {
            update() {
                const url = 'https://localhost:7273/api/Objects';
                axios.get(url)
                    .then((response) => {
                        this.dict = response.data;
                    })
                    .catch((error) =>{
                        console.log(error);
                    });
            },
        },

    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
