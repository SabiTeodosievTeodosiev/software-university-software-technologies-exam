package animelist.entity;

import javax.persistence.*;
import javax.persistence.criteria.CriteriaBuilder;

@Entity
@Table(name = "animes")
public class Anime {
    //TODO: Implement me ...
    private Integer id;

    private Integer rating;

    private String name;

    private String description;

    private String watched;

    public Anime() {}

    public Anime(Integer rating, String name, String description, String watched) {
        this.rating = rating;
        this.name = name;
        this.description = description;
        this.watched = watched;
    }

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return this.id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @Column(nullable = false) //, columnDefinition = (search in google JPA columnDefinion)
    public Integer getRating() {
        return this.rating;
    }

    public void setRating(Integer rating) {
        this.rating = rating;
    }

    @Column(nullable = false) //,unique=true, length = 100)
    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Column(nullable = false)
    public String getDescription() {
        return this.description;
    }

    public void setDescription(String director) {
        this.description = description;
    }

    @Column(nullable = false)
    public String getWatched() {
        return this.watched;
    }

    public void setWatched(String watched) {
        this.watched = watched;
    }

    //TODO: Implement me ... END
}
